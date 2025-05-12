using ShopManagement.Core.Domain.Orders.Entities;
using Zamin.Core.RequestResponse.Commands;

namespace ShopManagement.Core.RequestResponse.Orders.Command.Create;

public sealed class CreateOrderCommand : ICommand<Guid>
{
    public long AccountId { get; set; }
    public int PaymentMethod { get; set; }
    public double TotalAmount { get; set; }
    public double DiscountAmount { get; set; }
    public double PayAmount { get; set; }
    public bool IsPaid { get; set; }
    public bool IsCanceled { get; set; }
    public string IssueTrackingNo { get; set; } = string.Empty;
    public long RefId { get; set; }
    public List<OrderItem> Items { get; set; } = new List<OrderItem>();

}
