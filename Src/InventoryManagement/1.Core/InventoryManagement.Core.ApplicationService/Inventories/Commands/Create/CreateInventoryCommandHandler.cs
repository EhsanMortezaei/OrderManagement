﻿using InventoryManagement.Core.Contracts.Inventories.Commands;
using InventoryManagement.Core.Domain.Inventories.Entities;
using InventoryManagement.Core.RequestResponse.Inventories.Commands.Create;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace InventoryManagement.Core.ApplicationService.Inventories.Commands.Create;

// sealed  /  primarry constructor
public sealed class CreateInventoryCommandHandler(ZaminServices zaminServices,
    IInventoryCommandRepository inventoryCommandRepository) : CommandHandler<CreateInventoryCommand, Guid>(zaminServices)
{
    public override async Task<CommandResult<Guid>> Handle(CreateInventoryCommand command)
    {
        var inventory = new Inventory(command.ProductId, command.UnitPrice, command.InStock, command.Operations);

        await inventoryCommandRepository.InsertAsync(inventory);
        await inventoryCommandRepository.CommitAsync();

        return Ok(inventory.BusinessId.Value);
    }
}
