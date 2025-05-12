using Zamin.Core.RequestResponse.Commands;

namespace ShopManagement.Core.RequestResponse.OrderItems.Commands.Create;

public sealed class CreateOrderItemCommand : ICommand<Guid>
{
    public int Id { get; set; }
    public long ProductId { get; set; }
    public int Count { get; set; }
    public double UnitPrice { get; set; }
    public int DiscountRate { get; set; }
    public long OrderId { get; set; }
}
