using EDaemon.Domain.Items;
using System.Collections.Generic;

namespace EDaemon.Domain.Characters
{
    public class NonPlayerCharacter : Character
    {
        public string? Species { get; set; }
        public List<Item>? Bounty { get; set; }

        public NonPlayerCharacter(
                string name,
                CharacterAttribute attribute,
                double? currentHp = null,
                List<Skill>? skills = null,
                List<CombatSkill>? combatSkills = null,
                List<Enhancement>? enhancements = null,
                List<Weapon>? equippedWeapons = null,
                List<ProtectiveItem>? equipedProtection = null,
                string? species = null,
                List<Item>? bounty = null
            ) : base(name, attribute, currentHp, skills, combatSkills, enhancements, equippedWeapons, equipedProtection)
        {
            Species = species ?? name;
            Bounty = bounty ?? new List<Item>();
        }
    }
}
