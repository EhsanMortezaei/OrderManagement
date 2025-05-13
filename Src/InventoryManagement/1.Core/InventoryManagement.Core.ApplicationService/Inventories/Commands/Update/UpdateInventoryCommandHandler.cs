using Framework.Enums.Validation;
using InventoryManagement.Core.Contracts.Inventories.Commands;
using InventoryManagement.Core.RequestResponse.Inventories.Commands.Update;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace InventoryManagement.Core.ApplicationService.Inventories.Commands.Update;

public sealed class UpdateInventoryCommandHandler(ZaminServices zaminServices,
    IInventoryCommandRepository inventoryCommandRepository) : CommandHandler<UpdateInventoryCommand>(zaminServices)
{
    public override async Task<CommandResult> Handle(UpdateInventoryCommand command)
    {
        var inventory = await inventoryCommandRepository.GetAsync(command.Id);
        if (inventory is null)
            throw new InvalidEntityStateException(ErrorMessages.Get(ErrorMessageKey.InventoyError));

        inventory.Edit(command.ProductId, command.UnitPrice, command.Operations);
        await inventoryCommandRepository.CommitAsync();
        return Ok();
    }
}
