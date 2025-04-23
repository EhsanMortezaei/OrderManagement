using Microsoft.EntityFrameworkCore;
using ShopManagement.Core.Domain.ProductCategories.Entities;

namespace ShopManagement.Infra.Data.Sql.Commands.Products.Configs
{
    public class ProductCategoryConfig : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ProductCategory> builder)
        {
            throw new NotImplementedException();
        }
    }
}
