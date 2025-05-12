using Zamin.Core.Domain.Entities;

namespace InventoryManagement.Core.Domain.Inventories.Entities;

public sealed class InventoryOperation : Entity<int>
{
    public bool Operation { get;  set; }
    public long Count { get;  set; }
    public long OperatorId { get;  set; }
    public DateTime OperationDate { get;  set; }
    public long CurrentCount { get;  set; }
    public string Description { get;  set; } = string.Empty;
    public long OrderId { get;  set; }
    public long InventoryId { get;  set; }

     InventoryOperation() { }

    public InventoryOperation(bool operation,
                              long count,
                              long operatorId,
                              long currentCount,
                              string description,
                              long orderId,
                              long inventoryId)
    {
        Operation = operation;
        Count = count;
        OperatorId = operatorId;
        CurrentCount = currentCount;
        Description = description;
        OrderId = orderId;
        InventoryId = inventoryId;
        OperationDate = DateTime.Now;
    }

    public void Edit(bool operation,
                     long count,
                     long operatorId,
                     long currentCount,
                     string description,
                     long orderId,
                     long inventoryId)
    {
        Operation = operation;
        Count = count;
        OperatorId = operatorId;
        CurrentCount = currentCount;
        Description = description;
        OrderId = orderId;
        InventoryId = inventoryId;
        OperationDate = DateTime.Now;
    }
}
