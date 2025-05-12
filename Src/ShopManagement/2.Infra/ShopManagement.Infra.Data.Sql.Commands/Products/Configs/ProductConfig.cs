using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopManagement.Core.Domain.Products.Entities;

namespace ShopManagement.Infra.Data.Sql.Commands.Products.Configs;

public sealed class ProductConfig : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
        builder.Property(x => x.Descrption).HasMaxLength(1000).IsRequired();
        builder.Property(x => x.ShortDescription).HasMaxLength(500).IsRequired();
        builder.Property(x => x.Picture).HasMaxLength(100);
        builder.Property(x => x.PictureTitle).HasMaxLength(100);
        builder.Property(x => x.PictureAlt).HasMaxLength(100);
        builder.Property(x => x.Slug).HasMaxLength(100);

    }
}
