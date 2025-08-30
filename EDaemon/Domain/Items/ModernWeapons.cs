using EDaemon.Domain.Enums;
using System.Collections.Generic;

namespace EDaemon.Domain.Items
{
    public class ModernWeapons : Weapon
    {
        public List<ModernAmmunitionType> Ammunition { get; set; }
        public MagazineType MagType { get; set; }
        public int MagazineCapacity { get; set; }
        public int CurrentAmmoInMagazine { get; set; }
        public int RateOfFire { get; set; }
    }
}
