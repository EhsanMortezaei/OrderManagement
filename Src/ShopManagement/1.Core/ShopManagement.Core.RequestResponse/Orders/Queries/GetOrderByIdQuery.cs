using Zamin.Core.RequestResponse.Endpoints;
using Zamin.Core.RequestResponse.Queries;

namespace ShopManagement.Core.RequestResponse.Orders.Queries
{
    public class GetOrderByIdQuery : IQuery<OrderQr?>, IWebRequest
    {
        public int OrderId { get; set; }
        public string Path => "/api/Order/GetById";

    }
}
