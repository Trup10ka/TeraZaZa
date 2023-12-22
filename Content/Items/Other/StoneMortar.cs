using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace TeraZaZa.Content.Items.Other;

public class StoneMortar : ModItem
{
    public override void SetDefaults()
    {
        Item.useTime = 15;
        Item.useAnimation = 15;
        Item.autoReuse = true;
        Item.useStyle = ItemUseStyleID.Swing;
        Item.width = 15;
        Item.height = 15;
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