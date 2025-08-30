using EDaemon.Domain.System;
using System.Collections.Generic;

namespace EDaemon.Rules
{
    public interface IRuleEngine
    {
        void RegisterRule<T>(IRule<T> rule);
        void UnregisterRule<T>(string ruleName);
        List<RuleResult> ApplyRules<T>(T context);
    }
}
