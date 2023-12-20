using Microsoft.Xna.Framework;
using TeraZaZa.Content.Items.Zaza;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;


namespace TeraZaZa.Content.Tile.Cannabis;

public class BlueDreamCannabis : ModTile
{
    public override void SetStaticDefaults()
    {
        Main.tileSolid[Type] = false;
        Main.tileMergeDirt[Type] = false;
        Main.tileBlockLight[Type] = true;
        
        AddMapEntry(new Color( 34, 123, 255), CreateMapEntryName());

        DustType = DustID.BlueMoss;
        RegisterItemDrop(ItemType<WhiteWidow>());
    }
}