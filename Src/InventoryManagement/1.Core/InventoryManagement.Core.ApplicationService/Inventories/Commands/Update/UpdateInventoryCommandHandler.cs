using Framework.ErrorMessages;
using Framework.ValidationMessages;
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
        if (inventoryCommandRepository.Exists(x => x.ProductId == command.ProductId))
            throw new InvalidEntityStateException(ValidationMessages.DuplicateInventory);

        if (command.UnitPrice < 0)
            throw new InvalidEntityStateException(ValidationMessages.NegativePrice);

        if (command.InStock == false)
            throw new InvalidEntityStateException(ValidationMessages.NegativeStock);

        var inventory = await inventoryCommandRepository.GetAsync(command.Id)
            ?? throw new InvalidEntityStateException(ErrorMessage.InventoyError);

        inventory.Edit(command.ProductId, command.UnitPrice, command.Operations);
        await inventoryCommandRepository.CommitAsync();
        return Ok();
    }
}
