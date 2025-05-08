using Microsoft.EntityFrameworkCore;
using ShopManagement.Core.Domain.Orders.Entities;
using ShopManagement.Core.Domain.ProductCategories.Entities;
using ShopManagement.Core.Domain.Products.Entities;
using System.Reflection;
using Zamin.Extensions.Events.Outbox.Dal.EF;

namespace ShopManagement.Infra.Data.Sql.Commands.Common
{
    public class ShopManagementCommandDbContext : BaseOutboxCommandDbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

        public ShopManagementCommandDbContext(DbContextOptions<ShopManagementCommandDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
