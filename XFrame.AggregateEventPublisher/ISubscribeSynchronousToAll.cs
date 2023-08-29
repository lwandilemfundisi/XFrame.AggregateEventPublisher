using XFrame.Aggregates.Events;

namespace XFrame.AggregateEventPublisher
{
    public interface ISubscribeSynchronousToAll
    {
        Task HandleAsync(
            IReadOnlyCollection<IDomainEvent> domainEvents,
            CancellationToken cancellationToken);
    }
}
