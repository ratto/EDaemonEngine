using EDaemon.Domain.Items;
using System.Collections.Generic;

namespace EDaemon.Domain.Characters
{
    public class PlayerCharacter : Character
    {
        public int Age { get; set; }
        public int Level { get; set; }
        public double ExpPoints { get; set; }
        public List<Item>? CarriedItems { get; set; }

        public PlayerCharacter(
            string name, 
            int age,
            CharacterAttribute attribute,
            double? currentHp,
            int? level, 
            int? expPoints,
            List<Skill>? skills,
            List<CombatSkill>? combatSkills,
            List<Enhancement>? enhancements,
            List<Item>? carriedItems,
            List<Weapon>? equippedWeapons,
            List<ProtectiveItem>? equipedProtection
            ) : base(name, attribute, currentHp, skills, combatSkills, enhancements, equippedWeapons, equipedProtection)
        {
            Name = name;
            Age = age;
            Level = level ?? 1;
            ExpPoints = expPoints ?? 0;
            CarriedItems = carriedItems ?? new List<Item>();
        }
    }
}
