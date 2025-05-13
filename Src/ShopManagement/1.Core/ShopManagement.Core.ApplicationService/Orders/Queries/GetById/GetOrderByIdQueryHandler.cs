using ShopManagement.Core.Contracts.Orders.Queries;
using ShopManagement.Core.RequestResponse.Orders.Queries;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.RequestResponse.Queries;
using Zamin.Utilities;

namespace ShopManagement.Core.ApplicationService.Orders.Queries.GetById;

// query handler ha sade shavad
public sealed class GetOrderByIdQueryHandler : QueryHandler<GetOrderByIdQuery, OrderQr?>
{
    readonly IOrderQueryRepository _orderQueryRepository;

    public GetOrderByIdQueryHandler(ZaminServices zaminServices
        , IOrderQueryRepository orderQueryRepository) : base(zaminServices)
    {
        _orderQueryRepository = orderQueryRepository;
    }

    public override async Task<QueryResult<OrderQr?>> Handle(GetOrderByIdQuery query)
    {
        return Result(await _orderQueryRepository.ExecuteAsync(query));
    }
}
