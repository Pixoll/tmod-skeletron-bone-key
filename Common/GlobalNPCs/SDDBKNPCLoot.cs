using SkeletronDaytimeDropsBoneKey.Common.ItemDropRules;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace SkeletronDaytimeDropsBoneKey.Common.GlobalNPCs;

// ReSharper disable once UnusedType.Global
public class SDDBKNPCLoot : GlobalNPC {
    public override bool InstancePerEntity => true;

    public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot) {
        base.ModifyNPCLoot(npc, npcLoot);

        if (npc.type == NPCID.SkeletronHead) {
            npcLoot.Add(ItemDropRule.ByCondition(new SDDBKConditions.IsDaytime(), ItemID.BoneKey));
        }
    }
}
