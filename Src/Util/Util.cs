using Terraria;
using Terraria.Audio;
using Terraria.ID;

namespace TeraZaZa.Util;

public static class Util
{
    
    public static SoundStyle SmokeSound { get; } = new("TeraZaZa/Sounds/SmokeSound", 0);
    
    public static void SetupBasicZaza(this Item item)
    {
        item.width = 20;
        item.height = 20;
        item.useTime = 10;
        item.useAnimation = 10;
        item.rare = ItemRarityID.Green;
        item.UseSound = SoundID.Dig;
        item.useStyle = ItemUseStyleID.Swing;
        item.maxStack = 60;
    }
    

    public static void SetupBasicJoint(this Item item)
    {
        item.noMelee = true;
        item.width = 40;
        item.height = 40;
        item.useTime = 10;
        item.useAnimation = 10;
        item.rare = ItemRarityID.Blue;
        item.useStyle = ItemUseStyleID.EatFood;
        item.consumable = true;
        item.maxStack = 16;
    }
}