using Microsoft.EntityFrameworkCore;
using ShopManagement.Infra.Data.Sql.Queries.Orders;
using ShopManagement.Infra.Data.Sql.Queries.ProductCategories;
using ShopManagement.Infra.Data.Sql.Queries.Products;
using Zamin.Extensions.Events.Abstractions;
using Zamin.Infra.Data.Sql.Queries;
using Zamin.Utilities.DateTimes;

namespace ShopManagement.Infra.Data.Sql.Queries.Common
{
    public partial class ShopManagementQueryDbContext : BaseQueryDbContext
    {
        public ShopManagementQueryDbContext(DbContextOptions<ShopManagementQueryDbContext> options)
             : base(options)
        {
        }

        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog=Order; Integrated Security=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.TotalAmount).IsRequired();
            });

            modelBuilder.Entity<OutBoxEventItem>(entity =>
            {
                entity.Property(e => e.AccuredByUserId).HasMaxLength(255);

                entity.Property(e => e.AggregateName).HasMaxLength(255);

                entity.Property(e => e.AggregateTypeName).HasMaxLength(500);

                entity.Property(e => e.EventName).HasMaxLength(255);

                entity.Property(e => e.EventTypeName).HasMaxLength(500);
            });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
