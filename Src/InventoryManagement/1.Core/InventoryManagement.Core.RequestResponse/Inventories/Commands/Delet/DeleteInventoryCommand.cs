using Zamin.Core.RequestResponse.Commands;

namespace InventoryManagement.Core.RequestResponse.Inventories.Commands.Delet;

public sealed class DeleteInventoryCommand : ICommand
{
    public int Id { get; set; }
}
