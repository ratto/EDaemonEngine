using EDaemon.Domain.Enums;
using EDaemon.Domain.Utils;
using System.Collections;
using System.Collections.Generic;

namespace EDaemon.Domain.Items
{
    public class Weapon : Equipment
    {
        public WeaponClassType WeaponClass { get; set; }
        public int InitPenalty { get; set; }
        public List<Damage> DamageList { get; set; } = new List<Damage>();
        public List<WeaponType> WeaponTypes { get; set; } = new List<WeaponType>();
        public ICollection? WpnSubtype { get; set; }
        public int? MinReach { get; set; }
        public int? MaxReach { get; set; }
    }
}
