using XFrame.Aggregates;
using XFrame.Aggregates.Events;
using XFrame.Ids;

namespace XFrame.AggregateEventPublisher
{
    public interface IDomainEventPublisher
    {
        Task PublishAsync(
            IReadOnlyCollection<IDomainEvent> domainEvents,
            CancellationToken cancellationToken);

        [Obsolete("Use PublishAsync (without generics and aggregate identity)")]
        Task PublishAsync<TAggregate, TIdentity>(
            TIdentity id,
            IReadOnlyCollection<IDomainEvent> domainEvents,
            CancellationToken cancellationToken)
            where TAggregate : IAggregateRoot<TIdentity>
            where TIdentity : IIdentity;
    }
}
