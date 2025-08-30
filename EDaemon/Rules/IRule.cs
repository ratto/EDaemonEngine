using EDaemon.Domain.System;

namespace EDaemon.Rules
{
    public interface IRule<TContext>
    {
        string Name { get; }
        int Priority { get; }
        bool CanApply(TContext context);
        RuleResult Apply(TContext context);
        RuleResult FailToApply(TContext context);
    }
}
