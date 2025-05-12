using Zamin.Core.RequestResponse.Commands;

namespace InventoryManagement.Core.RequestResponse.Inventories.Commands.IncreaseInventory;

public sealed class IncreaseInventoryCommand : ICommand<Guid>
{
    public int InventoryId { get; set; }
    public long Count { get; set; }
    public string Description { get; set; } = string.Empty;

}
