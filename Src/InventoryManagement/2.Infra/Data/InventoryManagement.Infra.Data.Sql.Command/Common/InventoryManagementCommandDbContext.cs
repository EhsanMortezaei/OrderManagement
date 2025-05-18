using InventoryManagement.Core.Domain.Inventories.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Zamin.Extensions.Events.Outbox.Dal.EF;

namespace InventoryManagement.Infra.Data.Sql.Command.Common;

public sealed class InventoryManagementCommandDbContext(
    DbContextOptions<InventoryManagementCommandDbContext> options) : BaseOutboxCommandDbContext(options)
{
    public DbSet<Inventory> Inventories { get; set; }
    public DbSet<InventoryOperation> InventoryOperations { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
