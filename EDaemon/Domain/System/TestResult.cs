using System.Collections.Generic;

namespace EDaemon.Domain.System
{
    public class TestResult
    {
        public bool Success { get; set; }
        public List<RuleResult> AppliedModifiers { get; set; }
        public int ModTotal { get; set; }
        public int Score { get; set; }
        public int TotalScore { get; set; }
    }
}