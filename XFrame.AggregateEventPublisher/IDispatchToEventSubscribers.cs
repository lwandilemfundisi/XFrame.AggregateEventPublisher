using XFrame.Aggregates.Events;

namespace XFrame.AggregateEventPublisher
{
    public interface IDispatchToEventSubscribers
    {
        Task DispatchToSynchronousSubscribersAsync(
            IReadOnlyCollection<IDomainEvent> domainEvents,
            CancellationToken cancellationToken);

        Task DispatchToAsynchronousSubscribersAsync(
            IDomainEvent domainEvent,
            CancellationToken cancellationToken);
    }
}
