using System;

namespace EDaemon.Domain.Characters
{
    public class Enhancement
    {
        public Guid Id { get; set; }
        public string EnhancementName { get; set; }
        public int Cost { get; set; }
        public string Effect { get; set; } // TODO: create an effect class and make this prop a list of effects
        public string? Description { get; set; }
    }
}
