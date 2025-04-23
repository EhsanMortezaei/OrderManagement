using Zamin.Core.RequestResponse.Endpoints;
using Zamin.Core.RequestResponse.Queries;

namespace ShopManagement.Core.RequestResponse.Products.Query
{
    public class GetProductByIdQuery : IQuery<ProductQr?>, IWebRequest
    {
        public int ProductId { get; set; }

        public string Path => "/api/Product/GetById";
    }
}
