using TeraZaZa.Items.Zaza;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

using static Terraria.ModLoader.ModContent;
using static Terraria.ID.NPCID;

using TerrariaNPC = Terraria.NPC;

namespace TeraZaZa.Npc;

public class GlobalNpcCustomization : GlobalNPC
{
    public override void ModifyNPCLoot(TerrariaNPC npc, NPCLoot npcLoot)
    {
        if (!IsValidNPC(npc)) return;
        
        npcLoot.Add(
            ItemDropRule
                .OneFromOptions(10, ItemType<WhiteWidow>(), ItemType<MauiWowie>())
            );
        npcLoot.Add(
            ItemDropRule
                .OneFromOptions(10, ItemType<WhiteWidow>(), ItemType<MauiWowie>())
        );
    }

    private static bool IsValidNPC(TerrariaNPC npc)
    {
        return npc.type is 
            Zombie or 
            BigZombie or 
            SnowFlinx or 
            FemaleZombie or
            ZombieElf or 
            ZombieSuperman or
            MaggotZombie or
            SwampZombie or
            ZombieDoctor;
    }
}