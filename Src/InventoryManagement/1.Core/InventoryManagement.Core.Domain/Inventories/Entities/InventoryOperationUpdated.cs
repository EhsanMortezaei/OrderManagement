using Zamin.Core.Domain.Events;

namespace InventoryManagement.Core.Domain.Inventories.Entities
{
    //TODO: Hamed Move to Events
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
