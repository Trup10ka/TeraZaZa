using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;

namespace TeraZaZa.Tile.Other;

public class StoneMortar : ModTile
{
    public override void SetStaticDefaults()
    {
        Main.tileSolid[Type] = false;
        Main.tileSolidTop[Type] = true;
        Main.tileMergeDirt[Type] = false;
        Main.tileBlockLight[Type] = false;
        Main.tileTable[Type] = true;
        
        TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
        TileObjectData.addTile(Type);
        
        DustType = DustID.BubbleBurst_Blue;
        RegisterItemDrop(ItemType<Items.Other.StoneMortar>());
    }
}