using ShopManagement.Core.Contracts.Products.Queries;
using ShopManagement.Core.RequestResponse.Products.Query;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.RequestResponse.Queries;
using Zamin.Utilities;

namespace ShopManagement.Core.ApplicationService.Products.Queries.GetById
{
    public sealed class GetProductByIdQueryHandler(ZaminServices zainServices,
                                      IProductQueryRepository productQueryRepository) : QueryHandler<GetProductByIdQuery, ProductQr?>(zainServices)
    {
        public override async Task<QueryResult<ProductQr?>> Handle(GetProductByIdQuery query)
        {
            var product = await productQueryRepository.ExecuteAsync(query);

            return Result(product);
        }
    }
}
