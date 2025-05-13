using Framework.AuthHelper;
using InventoryManagement.Core.Contracts.Inventories.Commands;
using InventoryManagement.Core.RequestResponse.Inventories.Commands.IncreaseInventory;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace InventoryManagement.Core.ApplicationService.Inventories.Commands.IncreaseInventory;

public sealed class IncreaseInventoryCommandHandler(ZaminServices zaminServices,
                                       IAuthHelper authHelper,
                                       IInventoryCommandRepository inventoryCommandRepository) : CommandHandler<IncreaseInventoryCommand, Guid>(zaminServices)
{
    public override async Task<CommandResult<Guid>> Handle(IncreaseInventoryCommand command)
    {
        var inventory = await inventoryCommandRepository.GetGraphAsync(command.InventoryId);

        var operatorId = authHelper.CurrentAccountId();
        //const long operatorId = 1;
        inventory.Increase(command.Count, operatorId, command.Description);
        await inventoryCommandRepository.CommitAsync();

        return Ok(inventory.BusinessId.Value);
    }
}
