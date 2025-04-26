using InventoryManagement.Core.Domain.Inventories.Entities;
using InventoryManagement.Core.Domain.InventoryOperations.Entities;
using Microsoft.EntityFrameworkCore;
using Zamin.Extensions.Events.Outbox.Dal.EF;

namespace InventoryManagement.Infra.Data.Sql.Command.Common
{
    public class InventoryCommandDbContext : BaseOutboxCommandDbContext
    {
        public DbSet<Inventory> Inventories;
        public DbSet<InventoryOperation> InventoryOperations;
    }
}
