using EDaemon.Events;
using System;
using System.Collections.Generic;

namespace EDaemon.Domain.System
{
    public class TestResolvedEvent : IDaemonEvent
    {
        public List<Guid> Ids { get; set; }
        public TestResult TestResult { get; set; }
        public DateTime OccurredAt { get; set; }
        public string EventType { get; set; }
    }
}
