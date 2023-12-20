using Microsoft.Xna.Framework;
using TeraZaZa.Content.Items.Zaza;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;

namespace TeraZaZa.Content.Tile.Cannabis;

public class WhiteWidowCannabis : ModTile
{
    public override void SetStaticDefaults()
    {
        Main.tileSolid[Type] = false;
        Main.tileMergeDirt[Type] = false;
        Main.tileBlockLight[Type] = true;
        
        AddMapEntry(new Color( 237, 237, 236), CreateMapEntryName());
        
        DustType = DustID.BubbleBurst_Blue;
        RegisterItemDrop(ItemType<WhiteWidow>());
    }
}