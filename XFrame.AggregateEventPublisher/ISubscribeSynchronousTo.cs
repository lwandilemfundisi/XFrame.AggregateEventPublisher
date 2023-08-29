using XFrame.Aggregates;
using XFrame.Aggregates.Events;
using XFrame.Aggregates.Events.AggregateEvents;
using XFrame.Ids;

namespace XFrame.AggregateEventPublisher
{
    public interface ISubscribeSynchronousTo<TAggregate, in TIdentity, in TEvent>
        where TAggregate : IAggregateRoot<TIdentity>
        where TIdentity : IIdentity
        where TEvent : IAggregateEvent<TAggregate, TIdentity>
    {
        Task HandleAsync(
            IDomainEvent<TAggregate, TIdentity, TEvent> domainEvent,
            CancellationToken cancellationToken);
    }
}
