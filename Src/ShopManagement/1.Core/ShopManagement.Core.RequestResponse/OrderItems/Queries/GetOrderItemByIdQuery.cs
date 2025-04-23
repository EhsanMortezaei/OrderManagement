using Zamin.Core.RequestResponse.Endpoints;
using Zamin.Core.RequestResponse.Queries;

namespace ShopManagement.Core.RequestResponse.OrderItems.Queries
{
    public class GetOrderItemByIdQuery: IQuery<OrderItemQr?>, IWebRequest
    {
        public int Id { get; set; }

        public string Path => "/api/OrderItem/GetById";
    }
}
