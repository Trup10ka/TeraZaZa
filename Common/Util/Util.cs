using System;
using Terraria;
using Terraria.Audio;
using Terraria.ID;

namespace TeraZaZa.Common.Util;

public static class Util
{
    private static readonly Random Random = new ();
    public static SoundStyle SmokeSound { get; } = new("TeraZaZa/Content/Sounds/SmokeSound", 0);
    
    public static void SetupBasicZaza(this Item item)
    {
        item.width = 20;
        item.height = 20;
        item.useTime = 10;
        item.useAnimation = 10;
        item.rare = ItemRarityID.Green;
        item.UseSound = SoundID.Dig;
        item.useStyle = ItemUseStyleID.Swing;
        item.maxStack = 999;
    }
    
    public static void SetupBasicJoint(this Item item)
    {
        item.noMelee = true;
        item.width = 40;
        item.height = 40;
        item.useTime = 25;
        item.useAnimation = 25;
        item.rare = ItemRarityID.Blue;
        item.useStyle = ItemUseStyleID.EatFood;
        item.consumable = true;
        item.maxStack = 60;
    }
    public static bool ShouldConsumeItem(float chance)
    {
        if (chance is < 0 or > 1)
            throw new ArgumentOutOfRangeException(nameof(chance), "Internal Mod Error: Chance must be between 0 and 1, report this to the creator of the mod!");
        var random = Random.NextSingle();
        return chance > random;
    }
}