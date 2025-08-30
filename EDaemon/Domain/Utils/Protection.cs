using EDaemon.Domain.Enums;

namespace EDaemon.Domain.Utils
{
    public class Protection
    {
        public int ProtectiveIndex { get; set; }
        public DamageSourceType DamageSource { get; set; } = DamageSourceType.Kinetic;
    }
}
