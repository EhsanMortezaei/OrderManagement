using InventoryManagement.Infra.Data.Sql.Queries.Models;
using Microsoft.EntityFrameworkCore;
using Zamin.Infra.Data.Sql.Queries;

namespace InventoryManagement.Infra.Data.Sql.Queries.Common;

public class InventoryManagementQueryDbContext(DbContextOptions<InventoryManagementQueryDbContext> options)
    : BaseQueryDbContext(options)
{
    public virtual DbSet<Inventory> Inventories { get; set; }

    public virtual DbSet<InventoryOperation> InventoryOperations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Inventory>(entity =>
        {
            entity.Property(e => e.CreatedByUserId).HasMaxLength(50);
            entity.Property(e => e.ModifiedByUserId).HasMaxLength(50);
        });

        modelBuilder.Entity<InventoryOperation>(entity =>
        {
            entity.HasIndex(e => e.InventoryId1, "IX_InventoryOperations_InventoryId1");

            entity.Property(e => e.CreatedByUserId).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.ModifiedByUserId).HasMaxLength(50);

            entity.HasOne(d => d.InventoryId1Navigation).WithMany(p => p.InventoryOperations).HasForeignKey(d => d.InventoryId1);
        });
    }
}