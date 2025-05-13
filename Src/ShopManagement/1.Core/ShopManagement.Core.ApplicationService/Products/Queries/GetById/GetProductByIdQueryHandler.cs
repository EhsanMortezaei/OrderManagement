using ShopManagement.Core.Contracts.Products.Queries;
using ShopManagement.Core.RequestResponse.Products.Query;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.RequestResponse.Queries;
using Zamin.Utilities;

namespace ShopManagement.Core.ApplicationService.Products.Queries.GetById
{
    public sealed class GetProductByIdQueryHandler : QueryHandler<GetProductByIdQuery, ProductQr?>
    {
        readonly IProductQueryRepository _productQueryRepository;

        public GetProductByIdQueryHandler(ZaminServices zainServices,
                                          IProductQueryRepository productQueryRepository) : base(zainServices)
        {
            _productQueryRepository = productQueryRepository;
        }

        public override async Task<QueryResult<ProductQr?>> Handle(GetProductByIdQuery query)
        {
            var product = await _productQueryRepository.ExecuteAsync(query);

            return Result(product);
        }
    }
}
