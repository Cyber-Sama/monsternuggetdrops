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

			var config = ApiModConfigHelper.Config;

			var mobTypes = config.MobTypes;
			var patches = new Dictionary<string, List<JsonPatch>>();
			foreach (var mob in mobTypes)
			{
				patches[mob] = [
					new() {
						Op = EnumJsonPatchOp.AddMerge,
						Path = "/client/behaviors/4/quantitySlots",
						Value = JsonObject.FromJson("8")
					}
				];
			}

			var enabledItems = config.EnabledItemsWithMultipliers;
			foreach (var (mobCode, mob) in config.Mobs)
			{
				var split = mobCode.Split('-', 2);
				var array = new JArray();
				foreach (var (itemCode, item) in mob.LootTable)
				{
					if (!enabledItems.ContainsKey(itemCode) || !mobTypes.Contains(split[0]))
					{
						continue;
					}

					var multiplier = config.GlobalMultiplier * mob.Multiplier * enabledItems[itemCode];
					array.Add(new JObject
					{
						["type"] = "item",
						["code"] = itemCode,
						["quantity"] = new JObject
						{
							["avg"] = item.Quantity * multiplier,
							["var"] = item.Variability
						}
					});
				}

				if (array.Count == 0)
				{
					continue;
				}

				var type = split[1] == "*" ? "*" : $"*-{split[1]}";
				patches[split[0]].Add(new()
				{
					Op = EnumJsonPatchOp.Replace,
					Path = $"/server/behaviors/9/dropsByType/{type}",
					Value = new(array)
				});
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
			get => _api ?? throw new System.Exception("Api is null");
			set => _api = value;
		}

		static Mod? _mod;
		public static Mod Mod
		{
			get => _mod ?? throw new System.Exception("Mod is null");
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