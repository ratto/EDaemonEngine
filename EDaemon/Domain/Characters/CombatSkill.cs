using EDaemon.Domain.Enums;
using System;

namespace EDaemon.Domain.Characters
{
    public class CombatSkill
    {
        public Guid Id { get; set; }
        public string SkillName { get; set; }
        public AttributeType BaseAttribute { get; set; }
        public int AttributeBonus { get; set; }
        public int AttackBonus { get; set; }
        public int DefenseBonus { get; set; }
        public string? Description { get; set; }
    }
}
