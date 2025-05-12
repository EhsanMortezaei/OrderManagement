using InventoryManagement.Core.Domain.Inventories.Entities;
using Zamin.Core.RequestResponse.Commands;

namespace InventoryManagement.Core.RequestResponse.Inventories.Commands.Update;

public sealed class UpdateInventoryCommand : ICommand
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public double UnitPrice { get; set; }
    public List<InventoryOperation> Operations { get; set; } = new List<InventoryOperation>();
    public bool InStock { get; set; }
}
