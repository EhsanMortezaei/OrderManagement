using Zamin.Core.RequestResponse.Commands;

namespace InventoryManagement.Core.RequestResponse.Inventories.Commands.ReduceInventory;

public sealed class ReduceInventoryCommand : ICommand<Guid>
{
    public int InventoryId { get; set; }
    public int ProductId { get; set; }
    public long Count { get; set; }
    public string Description { get; set; } = string.Empty;
    public int OrderId { get; set; }


    public ReduceInventoryCommand()
    {

    }

    public ReduceInventoryCommand(int productId, int count, string description, int orderId)
    {
        ProductId = productId;
        Count = count;
        Description = description;
        OrderId = orderId;
    }
}
