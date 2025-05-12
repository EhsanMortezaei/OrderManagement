using Zamin.Core.Domain.Events;

namespace InventoryManagement.Core.Domain.Inventories.Events
{
    public sealed record InventoryUpdated(long count,
                                  long operatorId,
                                  string description) : IDomainEvent
    {
    }
}
