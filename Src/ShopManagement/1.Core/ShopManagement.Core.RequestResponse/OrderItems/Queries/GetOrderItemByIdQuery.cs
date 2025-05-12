using Zamin.Core.RequestResponse.Queries;

namespace ShopManagement.Core.RequestResponse.OrderItems.Queries;

public sealed class GetOrderItemByIdQuery : IQuery<OrderItemQr?>
{
    public int Id { get; set; }

}
