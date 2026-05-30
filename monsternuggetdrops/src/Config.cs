using System;
using System.Collections.Generic;

namespace MND
{
	public class Config
	{
		const string FILENAME = "monsterNuggetDrops.json";
		public static readonly string[] MOBS = ["drifter", "bowtorn", "shiver"];

		public static Config GetDefault() => new()
		{
			EnabledItemsWithMultipliers =
			{
				{ "flaxfibers", 1 },
				{ "gear-temporal", 1 },
				{ "gear-rusty", 1 },
				{ "cattailtops", 1 },
				{ "arrow-bone", 1 },
				{ "nugget-nativecopper", 1 },
				{ "nugget-cassiterite", 1 },
				{ "nugget-sphalerite", 1 },
				{ "nugget-galena", 1 },
				{ "nugget-nativesilver", 1 },
				{ "nugget-hematite", 1 },
				{ "hide-scraped-small", 1 },
				{ "hide-scraped-medium", 1 },
				{ "stone-bauxite", 1 },
				{ "stone-meteorite-iron", 1 },
				{ "stackrandomizer-alljonas", 1 }
			},
			Mobs = new()
			{
				{
					"drifter-normal",
					new()
					{
						LootTable = new()
						{
							{
								"flaxfibers",
								new()
								{
									Quantity = 0.25f
								}
							},
							{
								"gear-temporal",
								new()
								{
									Quantity = 0.05f
								}
							},
							{
								"gear-rusty",
								new()
								{
									Quantity = 0.02f
								}
							},
							{
								"cattailtops",
								new()
								{
									Quantity = 0.25f
								}
							},
							{
								"nugget-nativecopper",
								new()
								{
									Quantity = 0.25f
								}
							},
							{
								"nugget-cassiterite",
								new()
								{
									Quantity = 0.01f
								}
							},
							{
								"nugget-sphalerite",
								new()
								{
									Quantity = 0.05f
								}
							},
							{
								"nugget-galena",
								new()
								{
									Quantity = 0.02f
								}
							},
							{
								"nugget-nativesilver",
								new()
								{
									Quantity = 0.0025f
								}
							},
							{
								"hide-scraped-small",
								new()
								{
									Quantity = 0.05f
								}
							},
							{
								"stone-bauxite",
								new()
								{
									Quantity = 0.02f
								}
							},
							{
								"stone-meteorite-iron",
								new()
								{
									Quantity = 0.005f
								}
							}
						}
					}
				},
				{
					"drifter-deep",
					new()
					{
						LootTable = new()
						{
							{
								"flaxfibers",
								new()
								{
									Quantity = 0.5f
								}
							},
							{
								"gear-temporal",
								new()
								{
									Quantity = 0.0625f
								}
							},
							{
								"gear-rusty",
								new()
								{
									Quantity = 0.04f
								}
							},
							{
								"nugget-nativecopper",
								new()
								{
									Quantity = 0.5f
								}
							},
							{
								"nugget-cassiterite",
								new()
								{
									Quantity = 0.1f
								}
							},
							{
								"nugget-sphalerite",
								new()
								{
									Quantity = 0.05f
								}
							},
							{
								"nugget-galena",
								new()
								{
									Quantity = 0.02f
								}
							},
							{
								"nugget-nativesilver",
								new()
								{
									Quantity = 0.005f
								}
							},
							{
								"nugget-hematite",
								new()
								{
									Quantity = 0.025f
								}
							},
							{
								"hide-scraped-small",
								new()
								{
									Quantity = 0.1f
								}
							},

							{
								"stone-bauxite",
								new()
								{
									Quantity = 0.04f
								}
							},
							{
								"stone-meteorite-iron",
								new()
								{
									Quantity = 0.01f
								}
							}
						}
					}
				},
				{
					"drifter-tainted",
					new()
					{
						LootTable = new()
						{
							{
								"flaxfibers",
								new()
								{
									Quantity = 0.75f,
									Variability = 0.75f
								}
							},
							{
								"gear-temporal",
								new()
								{
									Quantity = 0.075f
								}
							},
							{
								"gear-rusty",
								new()
								{
									Quantity = 0.08f
								}
							},
							{
								"nugget-nativecopper",
								new()
								{
									Quantity = 0.75f,
									Variability = 0.75f
								}
							},
							{
								"nugget-cassiterite",
								new()
								{
									Quantity = 0.2f
								}
							},
							{
								"nugget-sphalerite",
								new()
								{
									Quantity = 0.05f
								}
							},
							{
								"nugget-galena",
								new()
								{
									Quantity = 0.02f
								}
							},
							{
								"nugget-nativesilver",
								new()
								{
									Quantity = 0.0075f
								}
							},
							{
								"nugget-hematite",
								new()
								{
									Quantity = 0.25f
								}
							},
							{
								"hide-scraped-small",
								new()
								{
									Quantity = 0.15f
								}
							},
							{
								"stone-bauxite",
								new()
								{
									Quantity = 0.06f
								}
							},
							{
								"stone-meteorite-iron",
								new()
								{
									Quantity = 0.015f
								}
							}
						}
					}
				},
				{
					"drifter-corrupt",
					new()
					{
						LootTable = new()
						{
							{
								"flaxfibers",
								new()
								{
									Variability = 1
								}
							},
							{
								"gear-temporal",
								new()
								{
									Quantity = 0.0875f
								}
							},
							{
								"gear-rusty",
								new()
								{
									Quantity = 0.15f
								}
							},
							{
								"nugget-nativecopper",
								new()
								{
									Variability = 1
								}
							},
							{
								"nugget-cassiterite",
								new()
								{
									Quantity = 0.3f
								}
							},
							{
								"nugget-sphalerite",
								new()
								{
									Quantity = 0.05f
								}
							},
							{
								"nugget-galena",
								new()
								{
									Quantity = 0.02f
								}
							},
							{
								"nugget-nativesilver",
								new()
								{
									Quantity = 0.01f
								}
							},
							{
								"nugget-hematite",
								new()
								{
									Quantity = 0.5f
								}
							},
							{
								"hide-scraped-small",
								new()
								{
									Quantity = 0.2f
								}
							},
							{
								"stone-bauxite",
								new()
								{
									Quantity = 0.08f
								}
							},
							{
								"stone-meteorite-iron",
								new()
								{
									Quantity = 0.02f
								}
							}
						}
					}
				},
				{
					"drifter-nightmare",
					new()
					{
						LootTable = new()
						{
							{
								"flaxfibers",
								new()
								{
									Quantity = 1.5f,
									Variability = 1
								}
							},
							{
								"gear-temporal",
								new()
								{
									Quantity = 0.1f
								}
							},
							{
								"gear-rusty",
								new()
								{
									Quantity = 0.3f
								}
							},
							{
								"nugget-nativecopper",
								new()
								{
									Quantity = 1.5f,
									Variability = 1
								}
							},
							{
								"nugget-cassiterite",
								new()
								{
									Quantity = 0.4f
								}
							},
							{
								"nugget-sphalerite",
								new()
								{
									Quantity = 0.05f
								}
							},
							{
								"nugget-galena",
								new()
								{
									Quantity = 0.02f
								}
							},
							{
								"nugget-nativesilver",
								new()
								{
									Quantity = 0.015f
								}
							},
							{
								"nugget-hematite",
								new()
								{
									Quantity = 0.75f,
									Variability = 0.75f
								}
							},
							{
								"hide-scraped-small",
								new()
								{
									Quantity = 0.25f
								}
							},
							{
								"stone-bauxite",
								new()
								{
									Quantity = 0.1f
								}
							},
							{
								"stone-meteorite-iron",
								new()
								{
									Quantity = 0.025f
								}
							}
						}
					}
				},
				{
					"drifter-double-headed",
					new()
					{
						LootTable = new()
						{
							{
								"flaxfibers",
								new()
								{
									Quantity = 3,
									Variability = 1
								}
							},
							{
								"gear-temporal",
								new()
								{
									Variability = 1
								}
							},
							{
								"gear-rusty",
								new()
								{
									Quantity = 5,
									Variability = 3
								}
							},
							{
								"nugget-hematite",
								new()
								{
									Quantity = 1.5f,
									Variability = 1
								}
							},
							{
								"stone-meteorite-iron",
								new()
								{
									Quantity = 0.05f
								}
							},
							{
								"stackrandomizer-alljonas",
								new()
								{
									Quantity = 0.4f
								}
							}
						}
					}
				},
				{
					"bowtorn-surface",
					new()
					{
						LootTable = new()
						{
							{
								"flaxfibers",
								new()
								{
									Quantity = 0.3333f
								}
							},
							{
								"gear-temporal",
								new()
								{
									Quantity = 0.05f
								}
							},
							{
								"gear-rusty",
								new()
								{
									Quantity = 0.03f
								}
							},
							{
								"cattailtops",
								new()
								{
									Quantity = 0.3333f
								}
							},
							{
								"arrow-bone",
								new()
								{
									Quantity = 0.75f,
									Variability = 0.75f
								}
							},
							{
								"nugget-nativecopper",
								new()
								{
									Quantity = 0.5f
								}
							},
							{
								"nugget-cassiterite",
								new()
								{
									Quantity = 0.015f
								}
							},
							{
								"nugget-sphalerite",
								new()
								{
									Quantity = 0.075f
								}
							},
							{
								"nugget-galena",
								new()
								{
									Quantity = 0.03f
								}
							},
							{
								"nugget-nativesilver",
								new()
								{
									Quantity = 0.005f
								}
							},
							{
								"hide-scraped-medium",
								new()
								{
									Quantity = 0.05f
								}
							},
							{
								"stone-bauxite",
								new()
								{
									Quantity = 0.03f
								}
							},
							{
								"stone-meteorite-iron",
								new()
								{
									Quantity = 0.01f
								}
							},
						}
					}
				},
				{
					"bowtorn-deep",
					new()
					{
						LootTable = new()
						{
							{
								"flaxfibers",
								new()
								{
									Quantity = 0.6667f,
									Variability = 0.6667f
								}
							},
							{
								"gear-temporal",
								new()
								{
									Quantity = 0.0625f
								}
							},
							{
								"gear-rusty",
								new()
								{
									Quantity = 0.06f
								}
							},
							{
								"arrow-bone",
								new()
								{
									Variability = 1
								}
							},
							{
								"nugget-nativecopper",
								new()
								{
									Quantity = 0.6667f,
									Variability = 0.6667f
								}
							},
							{
								"nugget-cassiterite",
								new()
								{
									Quantity = 0.15f
								}
							},
							{
								"nugget-sphalerite",
								new()
								{
									Quantity = 0.075f
								}
							},
							{
								"nugget-galena",
								new()
								{
									Quantity = 0.03f
								}
							},
							{
								"nugget-nativesilver",
								new()
								{
									Quantity = 0.01f
								}
							},
							{
								"nugget-hematite",
								new()
								{
									Quantity = 0.0333f
								}
							},
							{
								"hide-scraped-medium",
								new()
								{
									Quantity = 0.1f
								}
							},
							{
								"stone-bauxite",
								new()
								{
									Quantity = 0.06f
								}
							},
							{
								"stone-meteorite-iron",
								new()
								{
									Quantity = 0.02f
								}
							}
						}
					}
				},
				{
					"bowtorn-tainted",
					new()
					{
						LootTable = new()
						{
							{
								"flaxfibers",
								new()
								{
									Variability = 1
								}
							},
							{
								"gear-temporal",
								new()
								{
									Quantity = 0.075f
								}
							},
							{
								"gear-rusty",
								new()
								{
									Quantity = 0.12f
								}
							},
							{
								"arrow-bone",
								new()
								{
									Quantity = 1.5f,
									Variability = 1
								}
							},
							{
								"nugget-nativecopper",
								new()
								{
									Variability = 1
								}
							},
							{
								"nugget-cassiterite",
								new()
								{
									Quantity = 0.3f
								}
							},
							{
								"nugget-sphalerite",
								new()
								{
									Quantity = 0.075f
								}
							},
							{
								"nugget-galena",
								new()
								{
									Quantity = 0.03f
								}
							},
							{
								"nugget-nativesilver",
								new()
								{
									Quantity = 0.015f
								}
							},
							{
								"nugget-hematite",
								new()
								{
									Quantity = 0.3333f
								}
							},
							{
								"hide-scraped-medium",
								new()
								{
									Quantity = 0.15f
								}
							},
							{
								"stone-bauxite",
								new()
								{
									Quantity = 0.09f
								}
							},
							{
								"stone-meteorite-iron",
								new()
								{
									Quantity = 0.03f
								}
							}
						}
					}
				},
				{
					"bowtorn-corrupt",
					new()
					{
						LootTable = new()
						{
							{
								"flaxfibers",
								new()
								{
									Quantity = 1.5f,
									Variability = 1
								}
							},
							{
								"gear-temporal",
								new()
								{
									Quantity = 0.0875f
								}
							},
							{
								"gear-rusty",
								new()
								{
									Quantity = 0.25f
								}
							},
							{
								"arrow-bone",
								new()
								{
									Quantity = 2,
									Variability = 1
								}
							},
							{
								"nugget-nativecopper",
								new()
								{
									Quantity = 1.5f,
									Variability = 1
								}
							},
							{
								"nugget-cassiterite",
								new()
								{
									Quantity = 0.45f
								}
							},
							{
								"nugget-sphalerite",
								new()
								{
									Quantity = 0.075f
								}
							},
							{
								"nugget-galena",
								new()
								{
									Quantity = 0.03f
								}
							},
							{
								"nugget-nativesilver",
								new()
								{
									Quantity = 0.02f
								}
							},
							{
								"nugget-hematite",
								new()
								{
									Quantity = 0.6667f
								}
							},
							{
								"hide-scraped-medium",
								new()
								{
									Quantity = 0.2f
								}
							},
							{
								"stone-bauxite",
								new()
								{
									Quantity = 0.12f
								}
							},
							{
								"stone-meteorite-iron",
								new()
								{
									Quantity = 0.04f
								}
							}
						}
					}
				},
				{
					"bowtorn-nightmare",
					new()
					{
						LootTable = new()
						{
							{
								"flaxfibers",
								new()
								{
									Quantity = 2,
									Variability = 1
								}
							},
							{
								"gear-temporal",
								new()
								{
									Quantity = 0.1f
								}
							},
							{
								"gear-rusty",
								new()
								{
									Quantity = 0.5f
								}
							},
							{
								"arrow-bone",
								new()
								{
									Quantity = 3,
									Variability = 1
								}
							},
							{
								"nugget-nativecopper",
								new()
								{
									Quantity = 2,
									Variability = 1
								}
							},
							{
								"nugget-cassiterite",
								new()
								{
									Quantity = 0.6f
								}
							},
							{
								"nugget-sphalerite",
								new()
								{
									Quantity = 0.075f
								}
							},
							{
								"nugget-galena",
								new()
								{
									Quantity = 0.03f
								}
							},
							{
								"nugget-nativesilver",
								new()
								{
									Quantity = 0.03f
								}
							},
							{
								"nugget-hematite",
								new()
								{
									Variability = 1
								}
							},
							{
								"hide-scraped-medium",
								new()
								{
									Quantity = 0.25f
								}
							},
							{
								"stone-bauxite",
								new()
								{
									Quantity = 0.15f
								}
							},
							{
								"stone-meteorite-iron",
								new()
								{
									Quantity = 0.05f
								}
							}
						}
					}
				},
				{
					"bowtorn-gearfoot",
					new()
					{
						LootTable = new()
						{
							{
								"flaxfibers",
								new()
								{
									Quantity = 4,
									Variability = 1
								}
							},
							{
								"gear-temporal",
								new()
								{
									Quantity = 1.5f,
									Variability = 1
								}
							},
							{
								"gear-rusty",
								new()
								{
									Quantity = 7,
									Variability = 3
								}
							},
							{
								"arrow-bone",
								new()
								{
									Quantity = 4,
									Variability = 2
								}
							},
							{
								"nugget-hematite",
								new()
								{
									Quantity = 2,
									Variability = 1
								}
							},
							{
								"stone-meteorite-iron",
								new()
								{
									Quantity = 0.1f
								}
							},
							{
								"stackrandomizer-alljonas",
								new()
								{
									Quantity = 0.6f
								}
							}
						}
					}
				},
				{
					"shiver-surface",
					new()
					{
						LootTable = new()
						{
							{
								"flaxfibers",
								new()
								{
									Quantity = 0.3333f
								}
							},
							{
								"gear-temporal",
								new()
								{
									Quantity = 0.05f
								}
							},
							{
								"gear-rusty",
								new()
								{
									Quantity = 0.03f
								}
							},
							{
								"cattailtops",
								new()
								{
									Quantity = 0.3333f
								}
							},
							{
								"nugget-nativecopper",
								new()
								{
									Quantity = 0.3333f
								}
							},
							{
								"nugget-cassiterite",
								new()
								{
									Quantity = 0.015f
								}
							},
							{
								"nugget-sphalerite",
								new()
								{
									Quantity = 0.075f
								}
							},
							{
								"nugget-galena",
								new()
								{
									Quantity = 0.03f
								}
							},
							{
								"nugget-nativesilver",
								new()
								{
									Quantity = 0.005f
								}
							},
							{
								"hide-scraped-medium",
								new()
								{
									Quantity = 0.05f
								}
							},
							{
								"stone-bauxite",
								new()
								{
									Quantity = 0.03f
								}
							},
							{
								"stone-meteorite-iron",
								new()
								{
									Quantity = 0.01f
								}
							}
						}
					}
				},
				{
					"shiver-deep",
					new()
					{
						LootTable = new()
						{
							{
								"flaxfibers",
								new()
								{
									Quantity = 0.6667f,
									Variability = 0.6667f
								}
							},
							{
								"gear-temporal",
								new()
								{
									Quantity = 0.0625f
								}
							},
							{
								"gear-rusty",
								new()
								{
									Quantity = 0.06f
								}
							},
							{
								"nugget-nativecopper",
								new()
								{
									Quantity = 6667f,
									Variability = 6667f
								}
							},
							{
								"nugget-cassiterite",
								new()
								{
									Quantity = 0.15f
								}
							},
							{
								"nugget-sphalerite",
								new()
								{
									Quantity = 0.075f
								}
							},
							{
								"nugget-galena",
								new()
								{
									Quantity = 0.03f
								}
							},
							{
								"nugget-nativesilver",
								new()
								{
									Quantity = 0.01f
								}
							},
							{
								"nugget-hematite",
								new()
								{
									Quantity = 0.0333f
								}
							},
							{
								"hide-scraped-medium",
								new()
								{
									Quantity = 0.1f
								}
							},
							{
								"stone-bauxite",
								new()
								{
									Quantity = 0.06f
								}
							},
							{
								"stone-meteorite-iron",
								new()
								{
									Quantity = 0.02f
								}
							}
						}
					}
				},
				{
					"shiver-tainted",
					new()
					{
						LootTable = new()
						{
							{
								"flaxfibers",
								new()
								{
									Variability = 1
								}
							},
							{
								"gear-temporal",
								new()
								{
									Quantity = 0.075f
								}
							},
							{
								"gear-rusty",
								new()
								{
									Quantity = 0.12f
								}
							},
							{
								"nugget-nativecopper",
								new()
								{
									Variability = 1
								}
							},
							{
								"nugget-cassiterite",
								new()
								{
									Quantity = 0.3f
								}
							},
							{
								"nugget-sphalerite",
								new()
								{
									Quantity = 0.075f
								}
							},
							{
								"nugget-galena",
								new()
								{
									Quantity = 0.03f
								}
							},
							{
								"nugget-nativesilver",
								new()
								{
									Quantity = 0.015f
								}
							},
							{
								"nugget-hematite",
								new()
								{
									Quantity = 0.3333f
								}
							},
							{
								"hide-scraped-medium",
								new()
								{
									Quantity = 0.15f
								}
							},
							{
								"stone-bauxite",
								new()
								{
									Quantity = 0.09f
								}
							},
							{
								"stone-meteorite-iron",
								new()
								{
									Quantity = 0.03f
								}
							}
						}
					}
				},
				{
					"shiver-corrupt",
					new()
					{
						LootTable = new()
						{
							{
								"flaxfibers",
								new()
								{
									Quantity = 1.5f,
									Variability = 1
								}
							},
							{
								"gear-temporal",
								new()
								{
									Quantity = 0.0875f
								}
							},
							{
								"gear-rusty",
								new()
								{
									Quantity = 0.25f
								}
							},
							{
								"nugget-nativecopper",
								new()
								{
									Quantity = 1.5f,
									Variability = 1
								}
							},
							{
								"nugget-cassiterite",
								new()
								{
									Quantity = 0.45f
								}
							},
							{
								"nugget-sphalerite",
								new()
								{
									Quantity = 0.075f
								}
							},
							{
								"nugget-galena",
								new()
								{
									Quantity = 0.03f
								}
							},
							{
								"nugget-nativesilver",
								new()
								{
									Quantity = 0.02f
								}
							},
							{
								"nugget-hematite",
								new()
								{
									Quantity = 0.6667f
								}
							},
							{
								"hide-scraped-medium",
								new()
								{
									Quantity = 0.2f
								}
							},
							{
								"stone-bauxite",
								new()
								{
									Quantity = 0.12f
								}
							},
							{
								"stone-meteorite-iron",
								new()
								{
									Quantity = 0.04f
								}
							}
						}
					}
				},
				{
					"shiver-nightmare",
					new()
					{
						LootTable = new()
						{
							{
								"flaxfibers",
								new()
								{
									Quantity = 2,
									Variability = 1
								}
							},
							{
								"gear-temporal",
								new()
								{
									Quantity = 0.1f
								}
							},
							{
								"gear-rusty",
								new()
								{
									Quantity = 0.5f
								}
							},
							{
								"nugget-nativecopper",
								new()
								{
									Quantity = 2,
									Variability = 1
								}
							},
							{
								"nugget-cassiterite",
								new()
								{
									Quantity = 0.6f
								}
							},
							{
								"nugget-sphalerite",
								new()
								{
									Quantity = 0.075f
								}
							},
							{
								"nugget-galena",
								new()
								{
									Quantity = 0.03f
								}
							},
							{
								"nugget-nativesilver",
								new()
								{
									Quantity = 0.03f
								}
							},
							{
								"nugget-hematite",
								new()
								{
									Variability = 1
								}
							},
							{
								"hide-scraped-medium",
								new()
								{
									Quantity = 0.25f
								}
							},
							{
								"stone-bauxite",
								new()
								{
									Quantity = 0.15f
								}
							},
							{
								"stone-meteorite-iron",
								new()
								{
									Quantity = 0.05f
								}
							}
						}
					}
				},
				{
					"shiver-*",
					new()
					{
						LootTable = new()
						{
							{
								"flaxfibers",
								new()
								{
									Quantity = 4,
									Variability = 1
								}
							},
							{
								"gear-temporal",
								new()
								{
									Quantity = 1.5f,
									Variability = 1
								}
							},
							{
								"gear-rusty",
								new()
								{
									Quantity = 7,
									Variability = 3
								}
							},
							{
								"nugget-hematite",
								new()
								{
									Quantity = 2,
									Variability = 1
								}
							},
							{
								"stone-meteorite-iron",
								new()
								{
									Quantity = 0.1f
								}
							},
							{
								"stackrandomizer-alljonas",
								new()
								{
									Quantity = 0.6f
								}
							}
						}
					}
				}
			}
		};

		public static Config Get()
		{
			Config? config;
			try
			{
				config = ApiModConfigHelper.Api.LoadModConfig<Config>(FILENAME);
				config ??= GetDefault();
			}
			catch (Exception ex)
			{
				ApiModConfigHelper.Error("Config file broken, fix it or delete it :-/");
				ApiModConfigHelper.Error(ex);

				return GetDefault();
			}
			ApiModConfigHelper.StoreConfig(config, FILENAME);
			return config;
		}

		public float GlobalMultiplier { get; set; } = 1;
		public Dictionary<string, float> EnabledItemsWithMultipliers { get; set; } = [];
		public Dictionary<string, MobConfig> Mobs { get; set; } = [];
	}

	public class MobConfig
	{
		public float Multiplier { get; set; } = 1;
		public Dictionary<string, ItemConfig> LootTable { get; set; } = [];
	}

	public class ItemConfig
	{
		public float Quantity { get; set; } = 1;
		public float Variability { get; set; } = 0;
	}
}