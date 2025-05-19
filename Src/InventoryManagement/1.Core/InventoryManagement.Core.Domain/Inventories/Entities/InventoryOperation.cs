using Zamin.Core.Domain.Entities;

namespace InventoryManagement.Core.Domain.Inventories.Entities;

public sealed class InventoryOperation : Entity<int>
{
    #region Properties
    public bool Operation { get; private set; }
    public long Count { get; private set; }
    public long OperatorId { get; private set; }
    public DateTime OperationDate { get; private set; }
    public long CurrentCount { get; private set; }
    public string Description { get; private set; } = string.Empty;
    public long OrderId { get; private set; }
    public long InventoryId { get; private set; }
    #endregion

    #region Constructors
    private InventoryOperation() { }

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
    #endregion

    #region Commands
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
    #endregion
}
