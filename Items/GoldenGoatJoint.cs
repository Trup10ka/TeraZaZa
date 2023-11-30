using TeraZaZa.Util;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace TeraZaZa.Items;

public class GoldenGoatJoint : ModItem
{
    public override void SetDefaults()
    {
        Item.SetupBasicJoint();
    }

    public override void OnConsumeItem(Player player)
    {
        player.AddBuff(BuffID.WeaponImbueGold, 3600);
    }

    public override void AddRecipes()
    {
        var whiteWidow = CreateRecipe();
        whiteWidow.AddIngredient(ItemType<GoldenGoat>(), 2);
        whiteWidow.AddIngredient(ItemType<RollingPaper>());
        whiteWidow.AddTile(TileID.WorkBenches);
        whiteWidow.Register();
    }
}