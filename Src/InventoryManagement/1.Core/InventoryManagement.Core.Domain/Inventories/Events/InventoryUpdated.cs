using Zamin.Core.Domain.Events;

namespace InventoryManagement.Core.Domain.Inventories.Events
{
    public class InventoryUpdated(long count,
                                  long operatorId,
                                  string description) : IDomainEvent
    {
    }
}
