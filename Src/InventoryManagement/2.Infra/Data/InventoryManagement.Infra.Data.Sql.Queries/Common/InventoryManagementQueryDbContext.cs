using InventoryManagement.Infra.Data.Sql.Queries.Models;
using Microsoft.EntityFrameworkCore;
using Zamin.Infra.Data.Sql.Queries;

namespace InventoryManagement.Infra.Data.Sql.Queries.Common;

public partial class InventoryManagementQueryDbContext : BaseQueryDbContext
{
    public InventoryManagementQueryDbContext(DbContextOptions<InventoryManagementQueryDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Inventory> Inventories { get; set; }

    public virtual DbSet<InventoryOperation> InventoryOperations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog=Order; Integrated Security=True;TrustServerCertificate=True;");

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

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
