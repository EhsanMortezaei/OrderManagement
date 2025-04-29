using InventoryManagement.Core.Contracts.InventoryOperations.Commands;
using InventoryManagement.Core.RequestResponse.InventoryOperations.Commands.Delete;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Contracts.Data.Commands;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace InventoryManagement.Core.ApplicationService.InventoryOperations.Commands.Delete
{
    //public class DeleteInventoryOperationCommandHandler(ZaminServices zaminServices,
    //    IInventoryOperationCommandRepository inventoryOperationCommandRepository,
    //    IUnitOfWork inventoryOperationUnitOfWork) : CommandHandler<DeleteInventoryOperationCommand>(zaminServices)
    //{
    //    private readonly IUnitOfWork _inventoryOperationUnitOfWork = inventoryOperationUnitOfWork;
    //    private readonly IInventoryOperationCommandRepository _inventoryOperationCommandRepository = inventoryOperationCommandRepository;

    //    public override async Task<CommandResult> Handle(DeleteInventoryOperationCommand command)
    //    {
    //        var inventoryOperation = await _inventoryOperationCommandRepository.GetGraphAsync(command.Id);

    //        _inventoryOperationCommandRepository.Delete(inventoryOperation);
    //        await _inventoryOperationUnitOfWork.CommitAsync();

    //        return Ok();
    //    }
    //}
}
