namespace ShopManagement.Core.RequestResponse.OrderItems.Queries;

public sealed class OrderItemQr
{
    public int Id { get; set; }
    public long ProductId { get; set; }
    public int Count { get; set; }
    public double UnitPrice { get; set; }
    public int DiscountRate { get; set; }
    public long OrderId { get; set; }
}
