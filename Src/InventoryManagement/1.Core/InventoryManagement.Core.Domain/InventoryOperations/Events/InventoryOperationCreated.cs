using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zamin.Core.Domain.Events;

namespace InventoryManagement.Core.Domain.InventoryOperations.Events
{
    public class InventoryOperationCreated(bool operation,
                                           long count,
                                           long operatorId,
                                           long currentCount,
                                           string description,
                                           long orderId,
                                           long inventoryId) : IDomainEvent
    {
    }
}
