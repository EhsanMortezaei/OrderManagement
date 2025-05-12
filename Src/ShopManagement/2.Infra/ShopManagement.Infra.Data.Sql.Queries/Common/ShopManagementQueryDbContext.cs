using Microsoft.EntityFrameworkCore;
using ShopManagement.Infra.Data.Sql.Queries.Models;
using Zamin.Infra.Data.Sql.Queries;

namespace ShopManagement.Infra.Data.Sql.Queries.Common;

public partial class ShopManagementQueryDbContext : BaseQueryDbContext
{
    public ShopManagementQueryDbContext(DbContextOptions<ShopManagementQueryDbContext> options)
         : base(options)
    {
    }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductCategory> ProductCategories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog=Order; Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>(entity =>
         {
             entity.Property(e => e.CreatedByUserId).HasMaxLength(50);
             entity.Property(e => e.ModifiedByUserId).HasMaxLength(50);
         });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.HasIndex(e => e.OrderId1, "IX_OrderItems_OrderId1");

            entity.Property(e => e.CreatedByUserId).HasMaxLength(50);
            entity.Property(e => e.ModifiedByUserId).HasMaxLength(50);

            entity.HasOne(d => d.OrderId1Navigation).WithMany(p => p.OrderItems).HasForeignKey(d => d.OrderId1);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.CreatedByUserId).HasMaxLength(50);
            entity.Property(e => e.Descrption).HasMaxLength(1000);
            entity.Property(e => e.ModifiedByUserId).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Picture).HasMaxLength(100);
            entity.Property(e => e.PictureAlt).HasMaxLength(100);
            entity.Property(e => e.PictureTitle).HasMaxLength(100);
            entity.Property(e => e.ShortDescription).HasMaxLength(500);
            entity.Property(e => e.Slug).HasMaxLength(100);
        });

        modelBuilder.Entity<ProductCategory>(entity =>
        {
            entity.Property(e => e.CreatedByUserId).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.MetaDescription).HasMaxLength(200);
            entity.Property(e => e.ModifiedByUserId).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Picture).HasMaxLength(100);
            entity.Property(e => e.PictureAlt).HasMaxLength(100);
            entity.Property(e => e.PictureTitle).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
