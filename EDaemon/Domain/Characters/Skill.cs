using EDaemon.Domain.Enums;
using System;
using System.Collections.Generic;

namespace EDaemon.Domain.Characters
{
    public class Skill
    {
        public Guid Id { get; set; }
        public string SkillName { get; set; }
        public AttributeType BaseAttribute { get; set; }
        public int AttributeBonus { get; set; }
        public int SkillBonus { get; set; }
        public string Description { get; set; }
    }
}
