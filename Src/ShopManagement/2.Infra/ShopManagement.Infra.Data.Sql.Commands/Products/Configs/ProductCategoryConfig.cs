using Microsoft.EntityFrameworkCore;
using ShopManagement.Core.Domain.ProductCategories.Entities;

namespace ShopManagement.Infra.Data.Sql.Commands.Products.Configs;

public sealed class ProductCategoryConfig : IEntityTypeConfiguration<ProductCategory>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ProductCategory> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
        builder.Property(x => x.Description).HasMaxLength(1000).IsRequired();
        builder.Property(x => x.MetaDescription).HasMaxLength(200).IsRequired();
        builder.Property(x => x.Picture).HasMaxLength(100);
        builder.Property(x => x.PictureTitle).HasMaxLength(100);
        builder.Property(x => x.PictureAlt).HasMaxLength(100);
    }
}
