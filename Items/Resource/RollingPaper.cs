using Terraria.ID;
using Terraria.ModLoader;

namespace TeraZaZa.Items.Resource;

public class RollingPaper : ModItem
{
    public override void SetDefaults()
    {
        Item.noMelee = true;
        Item.width = 40;
        Item.width = 40;
        Item.height = 40;
        Item.useTime = 10;
        Item.useAnimation = 10;
        Item.rare = ItemRarityID.Green;
    }
}