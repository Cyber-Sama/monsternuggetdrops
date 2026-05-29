using HarmonyLib;
using Newtonsoft.Json.Linq;
using System;
using Vintagestory.API.Common.Entities;
using Vintagestory.API.Datastructures;
using Vintagestory.GameContent;

namespace MND
{
	[HarmonyPatch(typeof(EntityBehaviorHarvestable), "Initialize")]
	public static class HarvestableBehaviorInitializePatch
	{
		static Config? _config;
		public static Config Config
		{
			get => _config ?? throw new Exception("You forgot to instantiate Config :-/");
			set => _config = value;
		}

		public static void Prefix(EntityBehaviorHarvestable __instance, EntityProperties properties, ref JsonObject typeAttributes)
		{
			var code = __instance.entity.Code;
			if (code.FirstCodePart() == "shiver")
			{
				if (typeAttributes["drops"].Token is not JArray arr)
				{
					return;
				}

				for (var elem = arr.Next; elem != null; elem = elem.Next)
				{
					//I prefer that kind of "is not" blocks, to flatten things up
					if (elem is not JObject obj)
					{
						return;
					}

					//Code should always be here, just done that for the exemple
					var itemCode = obj["code"]?.Value<string>() ?? throw new Exception("Explain stuff here");

					if (obj["quantity"] is not JObject qty)
					{
						return;
					}

					//When you are sure things exist you can use "!" to declare a nullable "not null"
					var avg = (float)qty["avg"]!;
					var var = (float)qty["var"]!;

					//This should modify the internal Token used to setup the entity
					//qty["avg"] = 2 * Config.Blocks[code].SomeVar;
				}
			}
		}
	}
}