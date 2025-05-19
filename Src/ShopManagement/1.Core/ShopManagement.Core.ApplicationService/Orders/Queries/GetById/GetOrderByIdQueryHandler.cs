using ShopManagement.Core.Contracts.Orders.Queries;
using ShopManagement.Core.RequestResponse.Orders.Queries;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.RequestResponse.Queries;
using Zamin.Utilities;

namespace ShopManagement.Core.ApplicationService.Orders.Queries.GetById;

// query handler ha sade shavad
public sealed class GetOrderByIdQueryHandler(ZaminServices zaminServices
        , IOrderQueryRepository orderQueryRepository) : QueryHandler<GetOrderByIdQuery, OrderQr?>(zaminServices)
{
    public override async Task<QueryResult<OrderQr?>> Handle(GetOrderByIdQuery query)
    {
        return Result(await orderQueryRepository.ExecuteAsync(query));
    }
}
