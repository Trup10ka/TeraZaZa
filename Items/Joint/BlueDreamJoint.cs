using TeraZaZa.Items.Other;
using TeraZaZa.Items.Zaza;
using TeraZaZa.Util;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TeraZaZa.Items.Joint;

public class BlueDreamJoint : ModItem
{
    public override void SetDefaults()
    {
        Item.SetupBasicJoint();
    }
    public override bool? UseItem(Player player) => true;

    public override void OnConsumeItem(Player player)
    {
        player.AddBuff(BuffID.Spelunker, 5400);
    }

    public override void AddRecipes()
    {
        var whiteWidow = CreateRecipe();
        whiteWidow.AddIngredient(ModContent.ItemType<BlueDream>(), 2);
        whiteWidow.AddIngredient(ModContent.ItemType<RollingPaper>());
        whiteWidow.AddTile(TileID.WorkBenches);
        whiteWidow.Register();
    }
}