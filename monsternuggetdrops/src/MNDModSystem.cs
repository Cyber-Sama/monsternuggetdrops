using HarmonyLib;
using System;
using Vintagestory.API.Common;
using Vintagestory.API.Datastructures;
using Vintagestory.API.Server;
using Vintagestory.ServerMods.NoObf;

namespace MND
{
	public class MNDModSystem : ModSystem
	{
		Config? _config;

		public override void AssetsLoaded(ICoreAPI api)
		{
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

		public override void StartServerSide(ICoreServerAPI api)
		{
			ApiModHelper.Api = api;
			ApiModHelper.Mod = Mod;

			_config = Config.Get();

			HarvestableBehaviorInitializePatch.Config = _config;

			var harmony = new Harmony(Mod.Info.ModID);
			harmony.PatchAll();
		}

		public override void Dispose()
		{
			var harmony = new Harmony(Mod.Info.ModID);
			harmony.UnpatchAll();
		}
	}
	
	public static class ApiModHelper
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

		public static void Error(string message) => Mod.Logger.Error(message);
		public static void Error(Exception ex) => Mod.Logger.Error(ex);
		public static Config LoadConfig(string filename) => Api.LoadModConfig<Config>(filename);
		public static void StoreConfig(Config config, string filename) => Api.StoreModConfig(config, filename);
	}
}