using TeraZaZa.Util;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace TeraZaZa.Items;

public class WhiteWidowJoint : ModItem
{
    public override void SetDefaults()
    {
        Item.SetupBasicJoint();
    }

    public override void OnConsumeItem(Player player)
    {
        player.AddBuff(BuffID.Hunger, 3600);
    }

    public override void AddRecipes()
    {
        var whiteWidow = CreateRecipe();
        whiteWidow.AddIngredient(ItemType<WhiteWidow>(), 2);
        whiteWidow.AddIngredient(ItemType<RollingPaper>());
        whiteWidow.AddTile(TileID.WorkBenches);
        whiteWidow.Register();
    }
}