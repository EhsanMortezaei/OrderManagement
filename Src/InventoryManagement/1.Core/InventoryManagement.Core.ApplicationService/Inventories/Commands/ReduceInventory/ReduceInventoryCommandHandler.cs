using Framework.AuthHelper;
using InventoryManagement.Core.Contracts.Inventories.Commands;
using InventoryManagement.Core.RequestResponse.Inventories.Commands.ReduceInventory;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace InventoryManagement.Core.ApplicationService.Inventories.Commands.ReduceInventory;

public sealed class ReduceInventoryCommandHandler(ZaminServices zaminServices,
    IInventoryCommandRepository inventoryCommandRepository, IAuthHelper authHelper) : CommandHandler<ReduceInventoryCommand, Guid>(zaminServices)
{
    public override async Task<CommandResult<Guid>> Handle(ReduceInventoryCommand command)
    {
        var inventory = await inventoryCommandRepository.GetGraphAsync(command.InventoryId);

        var operatorId = authHelper.CurrentAccountId();
        inventory.Reduce(command.Count, operatorId, command.Description, 0);
        inventoryCommandRepository.Commit();
        return Ok(inventory.BusinessId.Value);
    }
}
