using System;

namespace EDaemon.Events
{
    public interface ICombatEvent
    {
        public Guid AttackerId { get; set; }
        public Guid DefenderId { get; set; }
        DateTime OccurredAt { get; }
        string EventType { get; }
    }
}
