using Zamin.Core.RequestResponse.Commands;

namespace InventoryManagement.Core.RequestResponse.InventoryOperations.Commands.Delete;

public sealed class DeleteInventoryOperationCommand : ICommand
{
    public int Id { get; set; }
}

