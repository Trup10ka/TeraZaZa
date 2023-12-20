﻿using Microsoft.Xna.Framework;
using TeraZaZa.Items.Zaza;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;


namespace TeraZaZa.Tile.Cannabis;

public class GoldenGoatCannabis : ModTile
{
    public override void SetStaticDefaults()
    {
        Main.tileSolid[Type] = false;
        Main.tileMergeDirt[Type] = false;
        Main.tileBlockLight[Type] = true;
        
        TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2);
        TileObjectData.addTile(Type);
        
        AddMapEntry(new Color( 204, 209, 24), CreateMapEntryName());

        DustType = DustID.BubbleBurst_Blue;
        RegisterItemDrop(ItemType<WhiteWidow>());
    }
}