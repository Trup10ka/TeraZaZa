using Microsoft.Xna.Framework;
using TeraZaZa.Items.Zaza;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace TeraZaZa.Tile;

public class MauiWowieCannabis : ModTile
{
    public override void SetStaticDefaults()
    {
        Main.tileSolid[Type] = false;
        Main.tileMergeDirt[Type] = false;
        Main.tileBlockLight[Type] = true;
        
        AddMapEntry(new Color(255, 0, 255), CreateMapEntryName());

        DustType = DustID.BubbleBurst_Blue;
        RegisterItemDrop(ItemType<MauiWowie>());
    }
}