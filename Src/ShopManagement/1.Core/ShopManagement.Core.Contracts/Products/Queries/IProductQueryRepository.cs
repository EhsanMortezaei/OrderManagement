using ShopManagement.Core.RequestResponse.Products.Query;

namespace ShopManagement.Core.Contracts.Products.Queries
{
    public interface IProductQueryRepository
    {
        public Task<ProductQr?> ExecuteAsync(GetProductByIdQuery query);
    }
}
