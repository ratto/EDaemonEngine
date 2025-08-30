using EDaemon.Domain.System;
using EDaemon.Rules.Contexts;
using System;
using System.Collections.Generic;

namespace EDaemon.Rules
{
    public class CriticalSuccessRule : IRule<CombatContext>
    {
        public string Name => "Critical Success";
        public int Priority => 100;

        bool IRule<CombatContext>.CanApply(CombatContext context)
        {
            return context.BaseRoll <= (int)Math.Ceiling((decimal)context.BaseAttack / 4);
        }

        RuleResult IRule<CombatContext>.Apply(CombatContext context)
        {
            return new RuleResult
            {
                Success = true,
                // Modifiers = new Dictionary<string, object> { ["DamageMultiplier"] = 2 }
            };
        }

        RuleResult IRule<CombatContext>.FailToApply(CombatContext context)
        {
            throw new NotImplementedException();
        }
    }
}
