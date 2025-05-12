using Zamin.Core.RequestResponse.Queries;

namespace ShopManagement.Core.RequestResponse.ProductCategories.Query;

public sealed class GetProductCategoryByIdQuery : IQuery<ProductCategoryQr?>
{
    public int ProductCategoryId { get; set; }
}
