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
        Main.tileSolid[Type] = false;
        Main.tileSolidTop[Type] = false;
        Main.tileMergeDirt[Type] = false;
        Main.tileBlockLight[Type] = false;
        Main.tileFrameImportant[Type] = true;
        
        TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
        TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.Table, TileObjectData.newTile.Width, 0);
        TileObjectData.addTile(Type);
        
        DustType = DustID.BubbleBurst_Blue;
        RegisterItemDrop(ItemType<Items.Other.StoneMortar>());
    }
}