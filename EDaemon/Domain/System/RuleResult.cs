using System.Collections.Generic;

namespace EDaemon.Domain.System
{
    public class RuleResult
    {
        public bool Success { get; set; }
        public RuleModifier Modifier { get; set; }
    }
}
