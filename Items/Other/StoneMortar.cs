using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace TeraZaZa.Items.Other;

public class StoneMortar : ModItem
{
    public override void SetDefaults()
    {
        Item.useTime = 10;
        Item.useAnimation = 10;
        Item.autoReuse = true;
        Item.useStyle = ItemUseStyleID.Swing;
        Item.width = 8;
        Item.height = 8;
        Item.maxStack = 9999;
        Item.value = Item.buyPrice(copper: 50);
        Item.rare = ItemRarityID.White;
        Item.consumable = true;

        Item.createTile = TileType<Tile.Other.StoneMortar>();
    }

    public override void AddRecipes()
    {
        CreateRecipe()
            .AddIngredient(ItemID.StoneBlock, 10)
            .AddTile(TileID.WorkBenches)
            .Register();
    }
}