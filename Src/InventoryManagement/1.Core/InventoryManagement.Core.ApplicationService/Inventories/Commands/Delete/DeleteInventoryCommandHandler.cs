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
    IInventoryCommandRepository inventoryCommandRepository) : CommandHandler<DeleteInventoryCommand>(zaminServices)
{
    public override async Task<CommandResult> Handle(DeleteInventoryCommand command)
    {
        var inventory = await inventoryCommandRepository.GetGraphAsync(command.Id) ?? throw new InvalidEntityStateException(ErrorMessages.Get(ErrorMessageKey.InventoyError));

        inventoryCommandRepository.Delete(inventory);
        await inventoryCommandRepository.CommitAsync();

        return Ok();
    }
}
