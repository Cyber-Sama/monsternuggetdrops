using System;
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
			if (api is not ICoreServerAPI)
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

			patch = new JsonPatch()
			{
				Op = EnumJsonPatchOp.AddMerge,
				Path = "/client/behaviors/4/quantitySlots",
				Value = JsonObject.FromJson("8")
			};

			foreach (var mob in Config.MOBS)
			{
				location = AssetLocation.Create($"entities/lore/{mob}");
				patch.File = location;

				jsonPatcher.ApplyPatch(0, location, patch, ref applied, ref notFound, ref errorCount);
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