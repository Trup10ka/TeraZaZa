using System.Collections.Generic;
using TeraZaZa.Content.GenPass;
using TeraZaZa.Content.Items.Resource;
using TeraZaZa.Content.Items.Zaza;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.WorldBuilding;
using static Terraria.ModLoader.ModContent;

namespace TeraZaZa.Common.Systems;

public class SystemCustomization : ModSystem
{
    public override void ModifyWorldGenTasks(List<GenPass> tasks, ref double totalWeight)
    {
        var index = tasks.FindIndex(pass => pass.Name.Equals("Sunflowers"));
        
        if (index != -1)
            tasks.Insert(index + 1, new CannabisGenPass("Cannabis", 100f));
    }

    public override void PostWorldGen()
    {
        int[] itemsToBeInsertedInChest = { ItemType<BlueDream>(), ItemType<WhiteWidow>(), ItemType<RollingPaper>() };

        var currentItemPointer = 0;
        for (var chestIndex = 0; chestIndex < Main.maxChests; chestIndex++)
        {
            var currentChest = Main.chest[chestIndex];
            if (
                currentChest == null || 
                !CheckIfChestUnderTheSurface(currentChest) ||
                WorldGen.genRand.NextBool(3)) continue;

            InsertItemsInChest(currentChest, itemsToBeInsertedInChest, ref currentItemPointer);
        }
    }
    
    private static void InsertItemsInChest(Chest chest, IReadOnlyList<int> itemsToBeInserted, ref int currentItemPointer)
    {
        var itemsInsertedInCurrentChest = 0;
        
        for (var itemIndex = 0; itemIndex < 40; itemIndex++)
        {
            if (chest.item[itemIndex].type != ItemID.None) continue;
            if (itemsInsertedInCurrentChest >= 5) break;
                
            var itemStack = WorldGen.genRand.Next(2, 5);
            
            chest.item[itemIndex].SetDefaults(itemsToBeInserted[currentItemPointer]);
            chest.item[itemIndex].stack = itemStack;
                
            itemsInsertedInCurrentChest += itemStack;
            currentItemPointer = (currentItemPointer + 1) % itemsToBeInserted.Count;
        }
    }

    private static bool CheckIfChestUnderTheSurface(Chest chest)
    {
        return chest.x > 100 &&
               chest.x < Main.maxTilesX - 100 &&
               chest.y > Main.worldSurface + 100 &&
               chest.y < Main.maxTilesY - 150;
    }
}