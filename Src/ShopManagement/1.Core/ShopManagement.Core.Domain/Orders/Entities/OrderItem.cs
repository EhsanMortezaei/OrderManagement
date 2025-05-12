using Zamin.Core.Domain.Entities;

namespace ShopManagement.Core.Domain.Orders.Entities;

public sealed class OrderItem : Entity<int>
{
    public long ProductId { get;  set; }
    public int Count { get;  set; }
    public double UnitPrice { get;  set; }
    public int DiscountRate { get;  set; }
    public long OrderId { get;  set; }

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
