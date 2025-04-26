using InventoryManagement.Core.Contracts.Inventories.Commands;
using InventoryManagement.Core.Domain.Inventories.Entities;
using InventoryManagement.Infra.Data.Sql.Command.Common;
using Zamin.Infra.Data.Sql.Commands;

namespace InventoryManagement.Infra.Data.Sql.Command.Inventories
{
    public class InventoryCommandRepository :
        BaseCommandRepository<Inventory, InventoryCommandDbContext, int>,
        IInventoryCommandRepository
    {
        public InventoryCommandRepository(InventoryCommandDbContext dbContext) : base(dbContext)
        {
        }
    }
}
