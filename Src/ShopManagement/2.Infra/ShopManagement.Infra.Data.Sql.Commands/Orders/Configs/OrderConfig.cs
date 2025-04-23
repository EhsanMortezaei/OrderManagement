using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopManagement.Core.Domain.Orders.Entities;

namespace ShopManagement.Infra.Data.Sql.Commands.Orders.Configs
{
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasMany(x => x.Items).WithOne(x => x.Order)
                .HasForeignKey(x => x.OrderId);
        }
    }
}
