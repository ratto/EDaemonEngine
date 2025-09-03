using System;

namespace EDaemon.Events
{
    public interface ITestEvent : IDaemonEvent
    {
        public Guid ActiveId { get; set; }
        public Guid? PassiveId { get; set; }
    }
}
