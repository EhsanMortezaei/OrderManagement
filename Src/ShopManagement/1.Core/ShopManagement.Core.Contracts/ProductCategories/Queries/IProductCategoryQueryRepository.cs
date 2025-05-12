using ShopManagement.Core.RequestResponse.ProductCategories.Query;

namespace ShopManagement.Core.Contracts.ProductCategories.Queries;

public interface IProductCategoryQueryRepository
{
    public Task<ProductCategoryQr?> ExecuteAsync(GetProductCategoryByIdQuery query);
}
