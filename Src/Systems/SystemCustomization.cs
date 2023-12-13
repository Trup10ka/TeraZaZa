using System.Collections.Generic;
using Terraria.ModLoader;
using Terraria.WorldBuilding;

namespace TeraZaZa.Systems;

public class SystemCustomization : ModSystem
{
    public override void ModifyWorldGenTasks(List<GenPass> tasks, ref double totalWeight)
    {
        var index = tasks.FindIndex(pass => pass.Name.Equals("Sunflowers"));
        
        if (index != -1)
            tasks.Insert(index + 1, new CannabisGenPass("Cannabis", 100f));
    }
}