using System;
using System.Collections.Generic;

namespace MND
{
	public class Config
	{
		const string FILENAME = "yourconfig.json";
		public static readonly string[] MOBS = ["drifter", "bowtorn", "shiver"];

		public bool Enabled { get; set; } = true;
		public float Multiplier { get; set; } = 1;
		public Dictionary<string, ConfigItem> Items { get; set; } = [];

		public static Config GetDefault() => new()
		{
			Items = new()
			{
				{
					"flaxfibers",
					new()
					{
						Mobs = new()
						{
							{
								"drifter",
								new()
								{
									Variants = new()
									{
										{
											"normal",
											new()
											{
												Quantity = 0.25f
											}
										},
										{
											"deep",
											new()
											{
												Quantity = 0.5f
											}
										},
										{
											"tainted",
											new()
											{
												Quantity = 0.75f,
												Variability = 0.75f
											}
										},
										{
											"corrupt",
											new()
											{
												Variability = 1
											}
										},
										{
											"nightmare",
											new()
											{
												Quantity = 1.5f,
												Variability = 1
											}
										},
										{
											"double-headed",
											new()
											{
												Quantity = 3,
												Variability = 1
											}
										}
									}
								}
							},
							{
								"bowtorn",
								new ()
								{
									Variants = new()
									{
										{
											"surface",
											new()
											{
												Quantity = 0.3333f
											}
										},
										{
											"deep",
											new()
											{
												Quantity = 0.6667f,
												Variability = 0.6667f
											}
										},
										{
											"tainted",
											new()
											{
												Variability = 1
											}
										},
										{
											"corrupt",
											new()
											{
												Quantity = 1.5f,
												Variability = 1
											}
										},
										{
											"nightmare",
											new()
											{
												Quantity = 2,
												Variability = 1
											}
										},
										{
											"gearfoot",
											new()
											{
												Quantity = 4,
												Variability = 1
											}
										}
									}
								}
							},
							{
								"shiver",
								new ()
								{
									Variants = new()
									{
										{
											"surface",
											new()
											{
												Quantity = 0.3333f
											}
										},
										{
											"deep",
											new()
											{
												Quantity = 0.6667f,
												Variability = 0.6667f
											}
										},
										{
											"tainted",
											new()
											{
												Variability = 1
											}
										},
										{
											"corrupt",
											new()
											{
												Quantity = 1.5f,
												Variability = 1
											}
										},
										{
											"nightmare",
											new()
											{
												Quantity = 2,
												Variability = 1
											}
										},
										{
											"*",
											new()
											{
												Quantity = 4,
												Variability = 1
											}
										}
									}
								}
							}
						}
					}
				},
				{
					"gear-temporal",
					new()
					{
						Mobs = new()
						{
							{
								"drifter",
								new()
								{
									Variants = new()
									{
										{
											"normal",
											new()
											{
												Quantity = 0.05f
											}
										},
										{
											"deep",
											new()
											{
												Quantity = 0.0625f
											}
										},
										{
											"tainted",
											new()
											{
												Quantity = 0.075f
											}
										},
										{
											"corrupt",
											new()
											{
												Quantity = 0.0875f
											}
										},
										{
											"nightmare",
											new()
											{
												Quantity = 0.1f,
												Variability = 1
											}
										},
										{
											"double-headed",
											new()
											{
												Variability = 1
											}
										}
									}
								}
							},
							{
								"bowtorn",
								new ()
								{
									Variants = new()
									{
										{
											"surface",
											new()
											{
												Quantity = 0.05f
											}
										},
										{
											"deep",
											new()
											{
												Quantity = 0.0625f
											}
										},
										{
											"tainted",
											new()
											{
												Quantity = 0.075f
											}
										},
										{
											"corrupt",
											new()
											{
												Quantity = 0.0875f
											}
										},
										{
											"nightmare",
											new()
											{
												Quantity = 0.1f
											}
										},
										{
											"gearfoot",
											new()
											{
												Quantity = 1.5f,
												Variability = 1
											}
										}
									}
								}
							},
							{
								"shiver",
								new ()
								{
									Variants = new()
									{
										{
											"surface",
											new()
											{
												Quantity = 0.05f
											}
										},
										{
											"deep",
											new()
											{
												Quantity = 0.0625f
											}
										},
										{
											"tainted",
											new()
											{
												Quantity = 0.075f
											}
										},
										{
											"corrupt",
											new()
											{
												Quantity = 0.875f
											}
										},
										{
											"nightmare",
											new()
											{
												Quantity = 0.1f
											}
										},
										{
											"*",
											new()
											{
												Quantity = 1.5f,
												Variability = 1
											}
										}
									}
								}
							}
						}
					}
				},
				{
					"gear-rusty",
					new()
					{
						Mobs = new()
						{
							{
								"drifter",
								new()
								{
									Variants = new()
									{
										{
											"normal",
											new()
											{
												Quantity = 0.02f
											}
										},
										{
											"deep",
											new()
											{
												Quantity = 0.04f
											}
										},
										{
											"tainted",
											new()
											{
												Quantity = 0.08f
											}
										},
										{
											"corrupt",
											new()
											{
												Quantity = 0.15f
											}
										},
										{
											"nightmare",
											new()
											{
												Quantity = 0.3f
											}
										},
										{
											"double-headed",
											new()
											{
												Quantity = 5,
												Variability = 3
											}
										}
									}
								}
							},
							{
								"bowtorn",
								new ()
								{
									Variants = new()
									{
										{
											"surface",
											new()
											{
												Quantity = 0.03f
											}
										},
										{
											"deep",
											new()
											{
												Quantity = 0.06f
											}
										},
										{
											"tainted",
											new()
											{
												Quantity = 0.12f
											}
										},
										{
											"corrupt",
											new()
											{
												Quantity = 0.25f
											}
										},
										{
											"nightmare",
											new()
											{
												Quantity = 0.5f
											}
										},
										{
											"gearfoot",
											new()
											{
												Quantity = 7,
												Variability = 3
											}
										}
									}
								}
							},
							{
								"shiver",
								new ()
								{
									Variants = new()
									{
										{
											"surface",
											new()
											{
												Quantity = 0.03f
											}
										},
										{
											"deep",
											new()
											{
												Quantity = 0.06f
											}
										},
										{
											"tainted",
											new()
											{
												Quantity = 0.12f
											}
										},
										{
											"corrupt",
											new()
											{
												Quantity = 0.25f
											}
										},
										{
											"nightmare",
											new()
											{
												Quantity = 0.5f
											}
										},
										{
											"*",
											new()
											{
												Quantity = 7,
												Variability = 3
											}
										}
									}
								}
							}
						}
					}
				},
				{
					"cattailtops",
					new()
					{
						Mobs = new()
						{
							{
								"drifter",
								new()
								{
									Variants = new()
									{
										{
											"normal",
											new()
											{
												Quantity = 0.25f
											}
										}
									}
								}
							},
							{
								"bowtorn",
								new ()
								{
									Variants = new()
									{
										{
											"surface",
											new()
											{
												Quantity = 0.3333f
											}
										}
									}
								}
							},
							{
								"shiver",
								new ()
								{
									Variants = new()
									{
										{
											"surface",
											new()
											{
												Quantity = 0.3333f
											}
										}
									}
								}
							}
						}
					}
				},
				{
					"arrow-bone",
					new()
					{
						Mobs = new()
						{
							{
								"bowtorn",
								new ()
								{
									Variants = new()
									{
										{
											"surface",
											new()
											{
												Quantity = 0.75f,
												Variability = 0.75f
											}
										},
										{
											"deep",
											new()
											{
												Variability = 1
											}
										},
										{
											"tainted",
											new()
											{
												Quantity = 1.5f,
												Variability = 1
											}
										},
										{
											"corrupt",
											new()
											{
												Quantity = 2,
												Variability = 1
											}
										},
										{
											"nightmare",
											new()
											{
												Quantity = 3,
												Variability = 1
											}
										},
										{
											"gearfoot",
											new()
											{
												Quantity = 4,
												Variability = 2
											}
										}
									}
								}
							}
						}
					}
				},
				{
					"nugget-nativecopper",
					new()
					{
						Mobs = new()
						{
							{
								"drifter",
								new()
								{
									Variants = new()
									{
										{
											"normal",
											new()
											{
												Quantity = 0.25f
											}
										},
										{
											"deep",
											new()
											{
												Quantity = 0.5f
											}
										},
										{
											"tainted",
											new()
											{
												Quantity = 0.75f,
												Variability = 0.75f
											}
										},
										{
											"corrupt",
											new()
											{
												Variability = 1
											}
										},
										{
											"nightmare",
											new()
											{
												Quantity = 1.5f,
												Variability = 1
											}
										}
									}
								}
							},
							{
								"bowtorn",
								new ()
								{
									Variants = new()
									{
										{
											"surface",
											new()
											{
												Quantity = 0.5f
											}
										},
										{
											"deep",
											new()
											{
												Quantity = 0.6667f,
												Variability = 0.6667f
											}
										},
										{
											"tainted",
											new()
											{
												Variability = 1
											}
										},
										{
											"corrupt",
											new()
											{
												Quantity = 1.5f,
												Variability = 1
											}
										},
										{
											"nightmare",
											new()
											{
												Quantity = 2,
												Variability = 1
											}
										}
									}
								}
							},
							{
								"shiver",
								new ()
								{
									Variants = new()
									{
										{
											"surface",
											new()
											{
												Quantity = 0.3333f
											}
										},
										{
											"deep",
											new()
											{
												Quantity = 0.6667f,
												Variability = 0.6667f
											}
										},
										{
											"tainted",
											new()
											{
												Variability = 1
											}
										},
										{
											"corrupt",
											new()
											{
												Quantity = 1.5f,
												Variability = 1
											}
										},
										{
											"nightmare",
											new()
											{
												Quantity = 2,
												Variability = 1
											}
										}
									}
								}
							}
						}
					}
				},
				{
					"nugget-cassiterite",
					new()
					{
						Mobs = new()
						{
							{
								"drifter",
								new()
								{
									Variants = new()
									{
										{
											"normal",
											new()
											{
												Quantity = 0.01f
											}
										},
										{
											"deep",
											new()
											{
												Quantity = 0.1f
											}
										},
										{
											"tainted",
											new()
											{
												Quantity = 0.2f
											}
										},
										{
											"corrupt",
											new()
											{
												Quantity = 0.3f
											}
										},
										{
											"nightmare",
											new()
											{
												Quantity = 0.4f
											}
										}
									}
								}
							},
							{
								"bowtorn",
								new ()
								{
									Variants = new()
									{
										{
											"surface",
											new()
											{
												Quantity = 0.015f
											}
										},
										{
											"deep",
											new()
											{
												Quantity = 0.15f
											}
										},
										{
											"tainted",
											new()
											{
												Quantity = 0.3f
											}
										},
										{
											"corrupt",
											new()
											{
												Quantity = 0.45f
											}
										},
										{
											"nightmare",
											new()
											{
												Quantity = 0.6f
											}
										}
									}
								}
							},
							{
								"shiver",
								new ()
								{
									Variants = new()
									{
										{
											"surface",
											new()
											{
												Quantity = 0.015f
											}
										},
										{
											"deep",
											new()
											{
												Quantity = 0.15f
											}
										},
										{
											"tainted",
											new()
											{
												Quantity = 0.3f
											}
										},
										{
											"corrupt",
											new()
											{
												Quantity = 0.45f
											}
										},
										{
											"nightmare",
											new()
											{
												Quantity = 0.6f
											}
										}
									}
								}
							}
						}
					}
				},
				{
					"hide-scraped-small",
					new()
					{
						Mobs = new()
						{
							{
								"drifter",
								new()
								{
									Variants = new()
									{
										{
											"normal",
											new()
											{
												Quantity = 0.05f
											}
										},
										{
											"deep",
											new()
											{
												Quantity = 0.1f
											}
										},
										{
											"tainted",
											new()
											{
												Quantity = 0.15f
											}
										},
										{
											"corrupt",
											new()
											{
												Quantity = 0.2f
											}
										},
										{
											"nightmare",
											new()
											{
												Quantity = 0.25f
											}
										}
									}
								}
							}
						}
					}
				},
				{
					"hide-scraped-medium",
					new()
					{
						Mobs = new()
						{
							{
								"bowtorn",
								new ()
								{
									Variants = new()
									{
										{
											"surface",
											new()
											{
												Quantity = 0.05f
											}
										},
										{
											"deep",
											new()
											{
												Quantity = 0.1f
											}
										},
										{
											"tainted",
											new()
											{
												Quantity = 0.15f
											}
										},
										{
											"corrupt",
											new()
											{
												Quantity = 0.2f
											}
										},
										{
											"nightmare",
											new()
											{
												Quantity = 0.25f
											}
										}
									}
								}
							},
							{
								"shiver",
								new ()
								{
									Variants = new()
									{
										{
											"surface",
											new()
											{
												Quantity = 0.05f
											}
										},
										{
											"deep",
											new()
											{
												Quantity = 0.1f
											}
										},
										{
											"tainted",
											new()
											{
												Quantity = 0.15f
											}
										},
										{
											"corrupt",
											new()
											{
												Quantity = 0.2f
											}
										},
										{
											"nightmare",
											new()
											{
												Quantity = 0.25f
											}
										}
									}
								}
							}
						}
					}
				},
				{
					"nugget-sphalerite",
					new()
					{
						Mobs = new()
						{
							{
								"drifter",
								new()
								{
									Variants = new()
									{
										{
											"normal",
											new()
											{
												Quantity = 0.05f
											}
										},
										{
											"deep",
											new()
											{
												Quantity = 0.05f
											}
										},
										{
											"tainted",
											new()
											{
												Quantity = 0.05f
											}
										},
										{
											"corrupt",
											new()
											{
												Quantity = 0.05f
											}
										},
										{
											"nightmare",
											new()
											{
												Quantity = 0.05f
											}
										}
									}
								}
							},
							{
								"bowtorn",
								new ()
								{
									Variants = new()
									{
										{
											"surface",
											new()
											{
												Quantity = 0.075f
											}
										},
										{
											"deep",
											new()
											{
												Quantity = 0.075f
											}
										},
										{
											"tainted",
											new()
											{
												Quantity = 0.075f
											}
										},
										{
											"corrupt",
											new()
											{
												Quantity = 0.075f
											}
										},
										{
											"nightmare",
											new()
											{
												Quantity = 0.075f
											}
										}
									}
								}
							},
							{
								"shiver",
								new ()
								{
									Variants = new()
									{
										{
											"surface",
											new()
											{
												Quantity = 0.075f
											}
										},
										{
											"deep",
											new()
											{
												Quantity = 0.075f
											}
										},
										{
											"tainted",
											new()
											{
												Quantity = 0.075f
											}
										},
										{
											"corrupt",
											new()
											{
												Quantity = 0.075f
											}
										},
										{
											"nightmare",
											new()
											{
												Quantity = 0.075f
											}
										}
									}
								}
							}
						}
					}
				},
				{
					"nugget-hematite",
					new()
					{
						Mobs = new()
						{
							{
								"drifter",
								new()
								{
									Variants = new()
									{
										{
											"deep",
											new()
											{
												Quantity = 0.025f
											}
										},
										{
											"tainted",
											new()
											{
												Quantity = 0.25f
											}
										},
										{
											"corrupt",
											new()
											{
												Quantity = 0.5f
											}
										},
										{
											"nightmare",
											new()
											{
												Quantity = 0.75f,
												Variability = 0.75f
											}
										},
										{
											"double-headed",
											new()
											{
												Quantity = 1.5f,
												Variability = 1
											}
										}
									}
								}
							},
							{
								"bowtorn",
								new ()
								{
									Variants = new()
									{
										{
											"deep",
											new()
											{
												Quantity = 0.0333f
											}
										},
										{
											"tainted",
											new()
											{
												Quantity = 0.3333f
											}
										},
										{
											"corrupt",
											new()
											{
												Quantity = 0.6667f
											}
										},
										{
											"nightmare",
											new()
											{
												Variability = 1
											}
										},
										{
											"gearfoot",
											new()
											{
												Quantity = 2,
												Variability = 1
											}
										}
									}
								}
							},
							{
								"shiver",
								new ()
								{
									Variants = new()
									{
										{
											"deep",
											new()
											{
												Quantity = 0.0333f
											}
										},
										{
											"tainted",
											new()
											{
												Quantity = 0.3333f
											}
										},
										{
											"corrupt",
											new()
											{
												Quantity = 0.6667f
											}
										},
										{
											"nightmare",
											new()
											{
												Variability = 1
											}
										},
										{
											"*",
											new()
											{
												Quantity = 2,
												Variability = 1
											}
										}
									}
								}
							}
						}
					}
				},
				{
					"stone-bauxite",
					new()
					{
						Mobs = new()
						{
							{
								"drifter",
								new()
								{
									Variants = new()
									{
										{
											"normal",
											new()
											{
												Quantity = 0.02f
											}
										},
										{
											"deep",
											new()
											{
												Quantity = 0.04f
											}
										},
										{
											"tainted",
											new()
											{
												Quantity = 0.06f
											}
										},
										{
											"corrupt",
											new()
											{
												Quantity = 0.08f
											}
										},
										{
											"nightmare",
											new()
											{
												Quantity = 0.1f
											}
										}
									}
								}
							},
							{
								"bowtorn",
								new ()
								{
									Variants = new()
									{
										{
											"surface",
											new()
											{
												Quantity = 0.03f
											}
										},
										{
											"deep",
											new()
											{
												Quantity = 0.06f
											}
										},
										{
											"tainted",
											new()
											{
												Quantity = 0.09f
											}
										},
										{
											"corrupt",
											new()
											{
												Quantity = 0.12f
											}
										},
										{
											"nightmare",
											new()
											{
												Quantity = 0.15f
											}
										}
									}
								}
							},
							{
								"shiver",
								new ()
								{
									Variants = new()
									{
										{
											"surface",
											new()
											{
												Quantity = 0.03f
											}
										},
										{
											"deep",
											new()
											{
												Quantity = 0.06f
											}
										},
										{
											"tainted",
											new()
											{
												Quantity = 0.09f
											}
										},
										{
											"corrupt",
											new()
											{
												Quantity = 0.12f
											}
										},
										{
											"nightmare",
											new()
											{
												Quantity = 0.15f
											}
										}
									}
								}
							}
						}
					}
				},
				{
					"nugget-galena",
					new()
					{
						Mobs = new()
						{
							{
								"drifter",
								new()
								{
									Variants = new()
									{
										{
											"normal",
											new()
											{
												Quantity = 0.02f
											}
										},
										{
											"deep",
											new()
											{
												Quantity = 0.02f
											}
										},
										{
											"tainted",
											new()
											{
												Quantity = 0.02f
											}
										},
										{
											"corrupt",
											new()
											{
												Quantity = 0.02f
											}
										},
										{
											"nightmare",
											new()
											{
												Quantity = 0.02f
											}
										}
									}
								}
							},
							{
								"bowtorn",
								new ()
								{
									Variants = new()
									{
										{
											"normal",
											new()
											{
												Quantity = 0.03f
											}
										},
										{
											"deep",
											new()
											{
												Quantity = 0.03f
											}
										},
										{
											"tainted",
											new()
											{
												Quantity = 0.03f
											}
										},
										{
											"corrupt",
											new()
											{
												Quantity = 0.03f
											}
										},
										{
											"nightmare",
											new()
											{
												Quantity = 0.03f
											}
										}
									}
								}
							},
							{
								"shiver",
								new ()
								{
									Variants = new()
									{
										{
											"normal",
											new()
											{
												Quantity = 0.03f
											}
										},
										{
											"deep",
											new()
											{
												Quantity = 0.03f
											}
										},
										{
											"tainted",
											new()
											{
												Quantity = 0.03f
											}
										},
										{
											"corrupt",
											new()
											{
												Quantity = 0.03f
											}
										},
										{
											"nightmare",
											new()
											{
												Quantity = 0.03f
											}
										}
									}
								}
							}
						}
					}
				},
				{
					"stone-meteorite-iron",
					new()
					{
						Mobs = new()
						{
							{
								"drifter",
								new()
								{
									Variants = new()
									{
										{
											"normal",
											new()
											{
												Quantity = 0.005f
											}
										},
										{
											"deep",
											new()
											{
												Quantity = 0.01f
											}
										},
										{
											"tainted",
											new()
											{
												Quantity = 0.015f
											}
										},
										{
											"corrupt",
											new()
											{
												Quantity = 0.02f
											}
										},
										{
											"nightmare",
											new()
											{
												Quantity = 0.025f
											}
										},
										{
											"double-headed",
											new()
											{
												Quantity = 0.05f
											}
										}
									}
								}
							},
							{
								"bowtorn",
								new ()
								{
									Variants = new()
									{
										{
											"surface",
											new()
											{
												Quantity = 0.01f
											}
										},
										{
											"deep",
											new()
											{
												Quantity = 0.02f
											}
										},
										{
											"tainted",
											new()
											{
												Quantity = 0.03f
											}
										},
										{
											"corrupt",
											new()
											{
												Quantity = 0.04f
											}
										},
										{
											"nightmare",
											new()
											{
												Quantity = 0.05f
											}
										},
										{
											"gearfoot",
											new()
											{
												Quantity = 0.1f
											}
										}
									}
								}
							},
							{
								"shiver",
								new ()
								{
									Variants = new()
									{
										{
											"surface",
											new()
											{
												Quantity = 0.01f
											}
										},
										{
											"deep",
											new()
											{
												Quantity = 0.02f
											}
										},
										{
											"tainted",
											new()
											{
												Quantity = 0.03f
											}
										},
										{
											"corrupt",
											new()
											{
												Quantity = 0.04f
											}
										},
										{
											"nightmare",
											new()
											{
												Quantity = 0.05f
											}
										},
										{
											"*",
											new()
											{
												Quantity = 0.1f
											}
										}
									}
								}
							}
						}
					}
				},
				{
					"nugget-nativesilver",
					new()
					{
						Mobs = new()
						{
							{
								"drifter",
								new()
								{
									Variants = new()
									{
										{
											"normal",
											new()
											{
												Quantity = 0.0025f
											}
										},
										{
											"deep",
											new()
											{
												Quantity = 0.005f
											}
										},
										{
											"tainted",
											new()
											{
												Quantity = 0.0075f
											}
										},
										{
											"corrupt",
											new()
											{
												Quantity = 0.01f
											}
										},
										{
											"nightmare",
											new()
											{
												Quantity = 0.015f
											}
										}
									}
								}
							},
							{
								"bowtorn",
								new ()
								{
									Variants = new()
									{
										{
											"surface",
											new()
											{
												Quantity = 0.005f
											}
										},
										{
											"deep",
											new()
											{
												Quantity = 0.01f
											}
										},
										{
											"tainted",
											new()
											{
												Quantity = 0.015f
											}
										},
										{
											"corrupt",
											new()
											{
												Quantity = 0.02f
											}
										},
										{
											"nightmare",
											new()
											{
												Quantity = 0.03f
											}
										}
									}
								}
							},
							{
								"shiver",
								new ()
								{
									Variants = new()
									{
										{
											"surface",
											new()
											{
												Quantity = 0.005f
											}
										},
										{
											"deep",
											new()
											{
												Quantity = 0.01f
											}
										},
										{
											"tainted",
											new()
											{
												Quantity = 0.015f
											}
										},
										{
											"corrupt",
											new()
											{
												Quantity = 0.02f
											}
										},
										{
											"nightmare",
											new()
											{
												Quantity = 0.03f
											}
										}
									}
								}
							}
						}
					}
				},
				{
					"stackrandomizer-alljonas",
					new()
					{
						Mobs = new()
						{
							{
								"drifter",
								new()
								{
									Variants = new()
									{
										{
											"double-headed",
											new()
											{
												Quantity = 0.4f
											}
										}
									}
								}
							},
							{
								"bowtorn",
								new ()
								{
									Variants = new()
									{
										{
											"gearfoot",
											new()
											{
												Quantity = 0.6f
											}
										}
									}
								}
							},
							{
								"shiver",
								new ()
								{
									Variants = new()
									{
										{
											"*",
											new()
											{
												Quantity = 0.6f
											}
										}
									}
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
				config = ApiModHelper.Api.LoadModConfig<Config>(FILENAME);
				config ??= GetDefault();
			}
			catch (Exception ex)
			{
				ApiModHelper.Error("Config file broken, fix it or delete it :-/");
				ApiModHelper.Error(ex);

				return GetDefault();
			}
			ApiModHelper.StoreConfig(config, FILENAME);
			return config;
		}
	}

	public class ConfigMobVariant
	{
		public bool Enabled { get; set; } = true;
		public float Multiplier { get; set; } = 1;
		public float Quantity { get; set; } = 1;
		public float Variability { get; set; } = 0;
	}

	public class ConfigMob
	{
		public bool Enabled { get; set; } = true;
		public float Multiplier { get; set; } = 1;
		public Dictionary<string, ConfigMobVariant> Variants { get; set; } = [];
	}

	public class ConfigItem
	{
		public bool Enabled { get; set; } = true;
		public float Multiplier { get; set; } = 1;
		public Dictionary<string, ConfigMob> Mobs { get; set; } = [];
	}
}