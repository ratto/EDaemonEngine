using EDaemon.Events;
using System;
using System.Collections.Generic;

namespace EDaemon.Domain.System
{
    internal class CombatResolvedEvent : IDaemonEvent
    {
        public List<Guid> Ids { get; set; }

        public DateTime OccurredAt { get; set ; }

        public string EventType { get; set; }
        }
}
