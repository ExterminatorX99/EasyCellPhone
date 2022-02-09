using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EasyCellPhone
{
	public class EasyNPC : GlobalNPC
	{
		private static readonly Dictionary<int, short[]> NPCTypeToExtraItems = new()
		{
			[NPCID.GoblinTinkerer] = new[]
			{
				ItemID.MagicMirror,
				ItemID.DepthMeter,
				ItemID.Compass,
				ItemID.Radar,
				ItemID.TallyCounter,
				ItemID.LifeformAnalyzer,
			},
			[NPCID.Mechanic] = new[]
			{
				ItemID.DPSMeter,
				ItemID.Stopwatch,
				ItemID.MetalDetector,
				ItemID.FishermansGuide,
				ItemID.WeatherRadio,
				ItemID.Sextant,
			},
		};

		public override bool AppliesToEntity(NPC entity, bool lateInstantiation) => NPCTypeToExtraItems.ContainsKey(entity.type);

		public override void SetupShop(int type, Chest shop, ref int nextSlot)
		{
			if (!NPCTypeToExtraItems.TryGetValue(type, out var items))
				return;

			foreach (var item in items)
			{
				shop.item[nextSlot++].SetDefaults(item);
			}
		}
	}
}
