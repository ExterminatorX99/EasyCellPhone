using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EasyCellPhone
{
    public class EasyNPC : GlobalNPC
    {
        private static readonly short[] MechanicExtraItems =
        {
            ItemID.MagicMirror,
            ItemID.DepthMeter,
            ItemID.Compass,
            ItemID.Radar,
            ItemID.TallyCounter,
            ItemID.LifeformAnalyzer,
            ItemID.DPSMeter,
            ItemID.Stopwatch,
            ItemID.MetalDetector,
            ItemID.FishermansGuide,
            ItemID.WeatherRadio,
            ItemID.Sextant
        };

        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.Mechanic)
                foreach (short item in MechanicExtraItems)
                    shop.item[nextSlot++].SetDefaults(item);
        }
    }
}
