using TeraZaZa.Content.Items.Resource;
using TeraZaZa.Content.Items.Zaza;
using TeraZaZa.Content.Tile.Other;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using static TeraZaZa.Common.Util.Util;

namespace TeraZaZa.Content.Items.Joint;

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
        SoundEngine.PlaySound(SmokeSound.WithVolumeScale(5f).WithPitchOffset(.3f), player.position);
    }

    public override void AddRecipes()
    {
        CreateRecipe()
            .AddIngredient(ItemType<SuperSilverHaze>(), 2)
            .AddIngredient(ItemType<RollingPaper>())
            .AddConsumeItemCallback(
                (Recipe _, int type, ref int amount) =>
                {
                    if (
                        Main.LocalPlayer.adjTile[TileType<StoneMortar>()] && 
                        type == ItemType<SuperSilverHaze>() && 
                        ShouldConsumeItem(.35f)
                    ) 
                        amount--;
                })
            .Register();
    }
}