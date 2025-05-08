using InventoryManagement.Core.Domain.Inventories.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Zamin.Extensions.Events.Outbox.Dal.EF;

namespace InventoryManagement.Infra.Data.Sql.Command.Common
{
    public class InventoryManagementCommandDbContext : BaseOutboxCommandDbContext
    {
        public DbSet<Inventory> Inventories {  get; set; }
        public DbSet<InventoryOperation> InventoryOperations {  get; set; }

        public InventoryManagementCommandDbContext(DbContextOptions<InventoryManagementCommandDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
