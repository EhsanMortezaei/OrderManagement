using Zamin.Core.RequestResponse.Queries;

namespace ShopManagement.Core.RequestResponse.Products.Query;

public sealed class GetProductByIdQuery : IQuery<ProductQr?>
{
    public int ProductId { get; set; }
}
