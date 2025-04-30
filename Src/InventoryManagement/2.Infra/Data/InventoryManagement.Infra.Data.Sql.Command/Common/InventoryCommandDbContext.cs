using InventoryManagement.Core.Domain.Inventories.Entities;
using Microsoft.EntityFrameworkCore;
using Zamin.Extensions.Events.Outbox.Dal.EF;

namespace InventoryManagement.Infra.Data.Sql.Command.Common
{
    public class InventoryCommandDbContext : BaseOutboxCommandDbContext
    {
        public DbSet<Inventory> Inventories {  get; set; }
        public DbSet<InventoryOperation> InventoryOperations {  get; set; }

        public InventoryCommandDbContext(DbContextOptions<InventoryCommandDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
