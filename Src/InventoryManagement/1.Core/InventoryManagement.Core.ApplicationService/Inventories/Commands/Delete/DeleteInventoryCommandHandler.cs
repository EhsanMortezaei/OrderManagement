using Framework.Enums.Validation;
using InventoryManagement.Core.Contracts.Inventories.Commands;
using InventoryManagement.Core.RequestResponse.Inventories.Commands.Delet;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Contracts.Data.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace InventoryManagement.Core.ApplicationService.Inventories.Commands.Delete;

public sealed class DeleteInventoryCommandHandler(ZaminServices zaminServices,
    IInventoryCommandRepository inventoryCommandRepository,
    IUnitOfWork inventoryUnitOfWork) : CommandHandler<DeleteInventoryCommand>(zaminServices)
{
    readonly IUnitOfWork _inventoryUnitOfWork = inventoryUnitOfWork;
    readonly IInventoryCommandRepository _inventoryCommandRepository = inventoryCommandRepository;

    public override async Task<CommandResult> Handle(DeleteInventoryCommand command)
    {
        var inventory = await _inventoryCommandRepository.GetGraphAsync(command.Id) ?? throw new InvalidEntityStateException(ErrorMessages.Get(ErrorMessageKey.InventoyError));

        _inventoryCommandRepository.Delete(inventory);
        await _inventoryCommandRepository.CommitAsync();

        return Ok();
    }
}
