using Zamin.Core.RequestResponse.Queries;

namespace ShopManagement.Core.RequestResponse.Orders.Queries;

public sealed class GetOrderByIdQuery : IQuery<OrderQr?>
{
    public int OrderId { get; set; }
}
