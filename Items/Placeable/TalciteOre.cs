using Terraria.ID;
using Terraria.ModLoader;
namespace Incantry.Items.Placeable
{
    public class TalciteOre : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Talcite Ore";
            item.width = 12;
            item.height = 12;
            item.toolTip = "This is a modded ore";
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.value = 50;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = mod.TileType("TalciteOreTile");
        }
    }
}
