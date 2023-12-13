using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TeraZaZa.Items.Other;

public class StoneMortar : ModItem
{
    public override void SetDefaults()
    {
        Item.width = 15;
        Item.height = 15;
        Item.maxStack = 9999;
        Item.value = Item.buyPrice(copper: 50);
        Item.rare = ItemRarityID.White;
    }
    
    public override void AddRecipes()
    {
        CreateRecipe()
            .AddIngredient(ItemID.StoneBlock, 10)
            .AddTile(TileID.WorkBenches)
            .Register();
    }
}