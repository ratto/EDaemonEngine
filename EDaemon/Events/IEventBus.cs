using System;
using System.Threading.Tasks;

namespace EDaemon.Events
{
    public interface IEventBus
    {
        Task PublishAsync<T>(T @event) where T : IDaemonEvent;
        void Subscribe<T>(Func<T, Task> handler) where T : IDaemonEvent;
        void Unsubscribe<T>(Func<T, Task> handler) where T : IDaemonEvent;
    }
}
