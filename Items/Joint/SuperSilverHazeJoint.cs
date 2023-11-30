using TeraZaZa.Items.Other;
using TeraZaZa.Items.Zaza;
using TeraZaZa.Util;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace TeraZaZa.Items.Joint;

public class SuperSilverHazeJoint : ModItem
{
    public override void SetDefaults()
    {
        Item.SetupBasicJoint();
    }
    public override bool? UseItem(Player player) => true;

    public override void OnConsumeItem(Player player)
    {
        player.AddBuff(BuffID.Swiftness, 3600);
    }

    public override void AddRecipes()
    {
        var superSilver = CreateRecipe();
        superSilver.AddIngredient(ItemType<SuperSilverHaze>(), 2);
        superSilver.AddIngredient(ItemType<RollingPaper>());
        superSilver.AddTile(TileID.WorkBenches);
        superSilver.Register();
    }
}