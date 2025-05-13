using Zamin.Core.Domain.Entities;

namespace ShopManagement.Core.Domain.Orders.Entities;

public sealed class OrderItem : Entity<int>
{
    public long ProductId { get; private set; }
    public int Count { get; private set; }
    public double UnitPrice { get; private set; }
    public int DiscountRate { get; private set; }
    public long OrderId { get; private set; }

    OrderItem() { }

    public OrderItem(long productId,
                     int count,
                     double unitPrice,
                     int discountRate)
    {
        ProductId = productId;
        Count = count;
        UnitPrice = unitPrice;
        DiscountRate = discountRate;
    }
}
