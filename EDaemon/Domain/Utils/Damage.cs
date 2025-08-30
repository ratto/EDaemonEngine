using EDaemon.Domain.Enums;

namespace EDaemon.Domain.Utils
{
    public class Damage
    {
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public DamageSourceType DamageType { get; set; } = DamageSourceType.Kinetic;
    }
}
