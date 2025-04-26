using Zamin.Core.Domain.Events;

namespace InventoryManagement.Core.Domain.InventoryOperations.Events
{
    public class InventoryOperationUpdated(bool operation,
                                           long count,
                                           long operatorId,
                                           long currentCount,
                                           string description,
                                           long orderId,
                                           long inventoryId) : IDomainEvent
    {
    }
}
