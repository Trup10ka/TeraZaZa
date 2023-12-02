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

public class WhiteWidowJoint : ModItem
{
    public override void SetDefaults()
    {
        Item.SetupBasicJoint();
    }
    public override bool? UseItem(Player player) => true;

    public override void OnConsumeItem(Player player)
    {
        player.AddBuff(BuffID.Hunger, 600);
        player.AddBuff(BuffID.MagicPower, 5400);
        SoundEngine.PlaySound(SmokeSound.WithVolumeScale(5f).WithPitchOffset(.3f), player.position);
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