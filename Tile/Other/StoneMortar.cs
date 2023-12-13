using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace TeraZaZa.Tile.Other;

public class StoneMortar : ModTile
{
    public override void SetStaticDefaults()
    {
        Main.tileSolid[Type] = false;
        Main.tileMergeDirt[Type] = false;
        Main.tileBlockLight[Type] = false;
        
        DustType = DustID.BubbleBurst_Blue;
        RegisterItemDrop(ItemType<Items.Other.StoneMortar>());
    }
}