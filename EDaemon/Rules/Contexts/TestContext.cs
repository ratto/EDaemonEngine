using EDaemon.Domain.Characters;

namespace EDaemon.Rules.Contexts
{
    public class TestContext
    {
        public Character ActiveCharacter { get; set; }
        public Character? PassiveCharacter { get; set; }
        public string ActiveSource { get; set; }
        public string? PassiveSource { get; set; }
        public int? Difficulty { get; set; }
        public int BaseRoll { get; set; }
    }
}
