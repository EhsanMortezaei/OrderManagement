﻿using InventoryManagement.Core.Contracts.Inventories.Commands;
using InventoryManagement.Core.Domain.Inventories.Entities;
using InventoryManagement.Infra.Data.Sql.Command.Common;
using Zamin.Infra.Data.Sql.Commands;

namespace InventoryManagement.Infra.Data.Sql.Command.Inventories;

public sealed class InventoryCommandRepository :
    BaseCommandRepository<Inventory, InventoryManagementCommandDbContext, int>,
    IInventoryCommandRepository
{
    public InventoryCommandRepository(InventoryManagementCommandDbContext dbContext) : base(dbContext)
    {
    }
}
