using Terraria;
using Terraria.ID;

namespace TeraZaZa.Util;

public static class Util
{
    public static void SetupBasicZaza(this Item item)
    {
        item.noMelee = true;
        item.width = 40;
        item.height = 40;
        item.useTime = 10;
        item.useAnimation = 10;
        item.rare = ItemRarityID.Green;
        item.UseSound = SoundID.Dig;
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
        item.UseSound = SoundID.Grass;
        item.maxStack = 16;
    }
}