using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;

namespace TeraZaZa.Content.Tile.Other;

public class StoneMortar : ModTile
{
    public override void SetStaticDefaults()
    {
        Main.tileSolid[Type] = true;
        Main.tileSolidTop[Type] = true;
        Main.tileMergeDirt[Type] = false;
        Main.tileBlockLight[Type] = false;
        
        TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
        TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.Table, 1, 0);
        TileObjectData.addTile(Type);
        
        DustType = DustID.BubbleBurst_Blue;
        RegisterItemDrop(ItemType<Items.Other.StoneMortar>());
    }
}