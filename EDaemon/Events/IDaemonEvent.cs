using System;
using System.Collections.Generic;

namespace EDaemon.Events
{
    public interface IDaemonEvent
    {
        List<Guid> Ids { get; }
        DateTime OccurredAt { get; }
        string EventType { get; }
    }
}
