using TeraZaZa.Items.Resource;
using TeraZaZa.Items.Zaza;
using TeraZaZa.Util;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using static TeraZaZa.Util.Util;

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
        SoundEngine.PlaySound(SmokeSound.WithVolumeScale(5f).WithPitchOffset(.3f), player.position);
    }

    public override void AddRecipes()
    {
        CreateRecipe()
            .AddIngredient(ItemType<SuperSilverHaze>(), 2)
            .AddIngredient(ItemType<RollingPaper>())
            .AddTile(TileID.WorkBenches)
            .Register();
    }
}