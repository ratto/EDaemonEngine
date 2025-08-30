using EDaemon.Domain.Characters;
using EDaemon.Domain.Enums;

namespace EDaemon.Rules.Contexts
{
    internal class CombatContext
    {
        public Character Attacker { get; set; }
        public Character Defender { get; set; }
        public int BaseAttack { get; set; }
        public DefensiveManeuverType DefensiveManeuver { get; set; } // TODO: chage to use string system
        public int BaseRoll { get; set; }
    }
}
