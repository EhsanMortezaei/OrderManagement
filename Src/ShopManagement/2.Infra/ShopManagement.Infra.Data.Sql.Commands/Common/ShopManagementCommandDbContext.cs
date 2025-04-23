using Microsoft.EntityFrameworkCore;
using ShopManagement.Core.Domain.Orders.Entities;
using ShopManagement.Core.Domain.ProductCategories.Entities;
using Zamin.Extensions.Events.Outbox.Dal.EF;

namespace ShopManagement.Infra.Data.Sql.Commands.Common
{
    public class ShopManagementCommandDbContext : BaseOutboxCommandDbContext
    {
        public DbSet<Core.Domain.Orders.Entities.Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Core.Domain.Products.Entities.Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
    }
}
