using ShopManagement.Core.Contracts.ProductCategories.Queries;
using ShopManagement.Core.RequestResponse.ProductCategories.Query;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.RequestResponse.Queries;
using Zamin.Utilities;

namespace ShopManagement.Core.ApplicationService.ProductCategories.Query.GetById;

public sealed class GetProductCategoryByIdQueryHandler(ZaminServices zaminServices,
    IProductCategoryQueryRepository productCategoryQueryRepository) : QueryHandler<GetProductCategoryByIdQuery, ProductCategoryQr?>(zaminServices)
{
    public override async Task<QueryResult<ProductCategoryQr?>> Handle(GetProductCategoryByIdQuery query)
    {
        var productCategory = await productCategoryQueryRepository.ExecuteAsync(query);

        return Result(productCategory);
    }
}
