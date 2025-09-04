using Terraria;
using Terraria.GameContent.ItemDropRules;

namespace SkeletronDaytimeDropsBoneKey.Common.ItemDropRules;

public static class SDDBKConditions {
    public class IsDaytime : IItemDropRuleCondition {
        public bool CanDrop(DropAttemptInfo info) => Main.IsItDay();

        public bool CanShowItemDropInUI() => true;

        public string GetConditionDescription() => null;
    }
}
