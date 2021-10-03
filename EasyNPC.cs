using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EasyCellPhone
{
	public class EasyNPC : GlobalNPC
	{
		private static readonly int[] GoblinExtraItems =
		{
			ItemID.MagicMirror,
			ItemID.DepthMeter,
			ItemID.Compass,
			ItemID.Radar,
			ItemID.TallyCounter,
			ItemID.LifeformAnalyzer
		};

		private static readonly int[] MechanicExtraItems =
		{
			ItemID.DPSMeter,
			ItemID.Stopwatch,
			ItemID.MetalDetector,
			ItemID.FishermansGuide,
			ItemID.WeatherRadio,
			ItemID.Sextant
		};

		public override void SetupShop(int type, Chest shop, ref int nextSlot)
		{
			switch (type)
			{
				case NPCID.GoblinTinkerer:
					foreach (int item in GoblinExtraItems)
						shop.item[nextSlot++].SetDefaults(item);
					break;
				case NPCID.Mechanic:
					foreach (int item in MechanicExtraItems)
						shop.item[nextSlot++].SetDefaults(item);
					break;
			}
		}
	}
}
