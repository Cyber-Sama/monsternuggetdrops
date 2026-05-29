using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using Vintagestory.API.Common;
using Vintagestory.API.Datastructures;
using Vintagestory.API.Server;
using Vintagestory.ServerMods.NoObf;

namespace MND
{
	public class MNDModSystem : ModSystem
	{
		public override void AssetsLoaded(ICoreAPI api)
		{
			if (api.Side != EnumAppSide.Server)
			{
				return;
			}

			var jsonPatcher = api.ModLoader.GetModSystem<ModJsonPatchLoader>();

			var location = AssetLocation.Create("itemtypes/resource/gear");
			var patch = new JsonPatch()
			{
				Op = EnumJsonPatchOp.Replace,
				Path = "/maxstacksizeByType/gear-temporal",
				Value = JsonObject.FromJson("16"),
				File = location
			};

			int applied = 0, notFound = 0, errorCount = 0;
			jsonPatcher.ApplyPatch(0, location, patch, ref applied, ref notFound, ref errorCount);

			if (!ApiModConfigHelper.Config.Enabled)
			{
				return;
			}

			var patches = new Dictionary<string, List<JsonPatch>>();
			foreach (var mob in Config.MOBS)
			{
				patches[mob] = [
					new() {
						Op = EnumJsonPatchOp.AddMerge,
						Path = "/client/behaviors/4/quantitySlots",
						Value = JsonObject.FromJson("8")
					}
				];
			}

			var data = new Dictionary<string, Dictionary<string, JArray>>();
			foreach (var (itemCode, item) in ApiModConfigHelper.Config.Items)
			{
				if (!item.Enabled)
				{
					continue;
				}

				foreach (var (mobCode, mob) in item.Mobs)
				{
					if (!mob.Enabled)
					{
						continue;
					}

					if (!data.TryGetValue(mobCode, out var mobData))
					{
						mobData = data[mobCode] = [];
					}

					foreach (var (variantCode, variant) in mob.Variants)
					{
						if (!variant.Enabled)
						{
							continue;
						}

						if (!mobData.TryGetValue(variantCode, out var variantData))
						{
							variantData = mobData[variantCode] = [];
						}

						var multiplier = ApiModConfigHelper.Config.Multiplier * item.Multiplier * mob.Multiplier * variant.Multiplier;
						var qtyObj = new JObject
						{
							["avg"] = variant.Quantity * multiplier,
							["var"] = variant.Variability
						};
						var patchObj = new JObject
						{
							["type"] = "item",
							["code"] = itemCode,
							["quantity"] = qtyObj
						};
						variantData.Add(patchObj);
					}
				}
			}

			foreach (var (mobCode, mobData) in data)
			{
				foreach (var (variantCode, variantData) in mobData)
				{
					patches[mobCode].Add(new()
					{
						Op = EnumJsonPatchOp.Replace,
						Path = variantCode == "*" ? "/server/behaviors/9/dropsByType/*" : $"/server/behaviors/9/dropsByType/*-{variantCode}",
						Value = new(variantData)
					});
				}
			}

			foreach (var (mobCode, items) in patches)
			{
				location = AssetLocation.Create($"entities/lore/{mobCode}");
				foreach (var item in items)
				{
					item.File = location;
					jsonPatcher.ApplyPatch(0, location, item, ref applied, ref notFound, ref errorCount);
				}
			}
		}

		public override void Start(ICoreAPI api)
		{
			if (api is not ICoreServerAPI sapi)
			{
				return;
			}
			ApiModConfigHelper.Api = sapi;
			ApiModConfigHelper.Mod = Mod;
		}
	}
	
	public static class ApiModConfigHelper
	{
		static ICoreServerAPI? _api;
		public static ICoreServerAPI Api
		{
			get => _api ?? throw new System.Exception("");
			set => _api = value;
		}

		static Mod? _mod;
		public static Mod Mod
		{
			get => _mod ?? throw new System.Exception("");
			set => _mod = value;
		}

		static Config? _config;
		public static Config Config
		{
			get
			{
				_config ??= Config.Get();
				return _config;
			}
		}

		public static void Error(string message) => Mod.Logger.Error(message);
		public static void Error(Exception ex) => Mod.Logger.Error(ex);
		public static Config LoadConfig(string filename) => Api.LoadModConfig<Config>(filename);
		public static void StoreConfig(Config config, string filename) => Api.StoreModConfig(config, filename);
	}
}