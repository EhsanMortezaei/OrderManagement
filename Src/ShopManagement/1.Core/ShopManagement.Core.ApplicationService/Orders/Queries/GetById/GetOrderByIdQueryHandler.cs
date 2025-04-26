using ShopManagement.Core.Contracts.Orders.Queries;
using ShopManagement.Core.RequestResponse.Orders.Queries;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.RequestResponse.Queries;
using Zamin.Utilities;

namespace ShopManagement.Core.ApplicationService.Orders.Queries.GetById
{
    public class GetOrderByIdQueryHandler : QueryHandler<GetOrderByIdQuery, OrderQr>
    {
        private readonly IOrderQueryRepository _orderQueryRepository;

        public GetOrderByIdQueryHandler(ZaminServices zaminServices
            , IOrderQueryRepository orderQueryRepository) : base(zaminServices)
        {
            _orderQueryRepository = orderQueryRepository;
        }

        public override async Task<QueryResult<OrderQr>> Handle(GetOrderByIdQuery query)
        {
            var order = await _orderQueryRepository.ExecuteAsync(query);

            return Result(order);
        }
    }
}
