using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopManagement.Core.Domain.Orders.Entities;
using ShopManagement.Core.Domain.ProductCategories.Entities;

namespace ShopManagement.Infra.Data.Sql.Commands.ProductCategories.Configs
{
    public class ProductCategoryConfig : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
        }
    }
}
