using Zamin.Core.RequestResponse.Endpoints;
using Zamin.Core.RequestResponse.Queries;

namespace ShopManagement.Core.RequestResponse.ProductCategories.Query
{
    public class GetProductCategoryByIdQuery : IQuery<ProductCategoryQr?>, IWebRequest
    {
        public int ProductCategoryId { get; set; }

        public string Path => "/api/Product/GetById";
    }
}
