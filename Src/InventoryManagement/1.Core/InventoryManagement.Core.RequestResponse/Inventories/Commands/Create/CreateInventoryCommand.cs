using InventoryManagement.Core.Domain.Inventories.Entities;
using Zamin.Core.RequestResponse.Commands;

namespace InventoryManagement.Core.RequestResponse.Inventories.Commands.Create;

public sealed class CreateInventoryCommand : ICommand<Guid>
{
    public int ProductId { get; set; }
    public double UnitPrice { get; set; }
    public List<InventoryOperation> Operations { get; set; } = new List<InventoryOperation>();
    public bool InStock { get; set; }
}
