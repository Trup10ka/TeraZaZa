using System;
using TeraZaZa.Items.Resource;
using TeraZaZa.Items.Zaza;
using TeraZaZa.Tile.Other;
using TeraZaZa.Util;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using static TeraZaZa.Util.Util;

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
        SoundEngine.PlaySound(SmokeSound.WithVolumeScale(5f).WithPitchOffset(.3f), player.position);
    }

    public override void AddRecipes()
    {
        CreateRecipe()
            .AddIngredient(ItemType<BlueDream>(), 2)
            .AddIngredient(ItemType<RollingPaper>())
            .AddConsumeItemCallback(
                (Recipe _, int type, ref int amount) =>
                {
                    if (
                        Main.LocalPlayer.adjTile[TileType<StoneMortar>()] && 
                        type == ItemType<BlueDream>() && 
                        ShouldConsumeItem(.35f)
                        ) 
                        amount--;
                })
            .Register();
    }
}