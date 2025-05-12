using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopManagement.Core.Domain.Orders.Entities;

namespace ShopManagement.Infra.Data.Sql.Commands.Orders.Configs;

public sealed class OrderConfig : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(x => x.Id);
        //builder.HasMany(x => x.Items).WithOne(x => x.Order)
        //.HasForeignKey(x => x.OrderId);
    }
}
