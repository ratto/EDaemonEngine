using EDaemon.Domain.Characters;
using System.Collections.Generic;

namespace EDaemon.Domain.System
{
    public class TestDetailedResult
    {
        public int BaseRoll { get; set; }
        public List<Character> Characters { get; set; }
        public int? Difficulty { get; set; } = null;
        public TestResult TestResult { get; set; }
    }
}
