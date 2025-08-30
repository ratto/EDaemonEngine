using EDaemon.Domain.Items;
using System;
using System.Collections.Generic;

namespace EDaemon.Domain.Characters
{
    public abstract class Character
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double CurrentHitPoints { get; set; }
        public double TotalHitPoints { get; set; }
        public CharacterAttribute Attribute { get; set; }
        public List<Skill>? SkillList { get; set; }
        public List<CombatSkill>? CombatSkillList { get; set; }
        public List<Enhancement>? EnhancementList { get; set; }
        public Weapon? EquippedWeapon { get; set; }
        public List<ProtectiveItem>? EquipedProtection { get; set; }

        public Character(string name, CharacterAttribute attribute)
        {
            Name = name;
            Attribute = attribute;
            TotalHitPoints = (attribute.Constitution + attribute.Strength) / 2;
            CurrentHitPoints = TotalHitPoints;
        }

        public Character(
            string name,
            CharacterAttribute attribute,
            double? currentHp,
            List<Skill>? skills, 
            List<CombatSkill>? combatSkills, 
            List<Enhancement>? enhancements
            )
        {
            Name = name;
            Attribute = attribute;
            TotalHitPoints = (attribute.Constitution + attribute.Strength) / 2;
            CurrentHitPoints = currentHp ?? TotalHitPoints;
            SkillList = skills ?? new List<Skill>();
            CombatSkillList = combatSkills ?? new List<CombatSkill>();
            EnhancementList = enhancements ?? new List<Enhancement>();
        }
    }
}
