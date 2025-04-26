using InventoryManagement.Core.Contracts.Inventories.Queries;
using InventoryManagement.Core.RequestResponse.Inventories.Queries;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.RequestResponse.Queries;
using Zamin.Utilities;

namespace InventoryManagement.Core.ApplicationService.Inventories.Queries.GetById
{
    public class GetInventoryByIdQueryHandler : QueryHandler<GetInventoryByIdQuery, InventoryQr>
    {
        private readonly IInventoryQueryRepository _inventoryQueryRepository;

        public GetInventoryByIdQueryHandler(ZaminServices zainServices,
            IInventoryQueryRepository inventoryQueryRepository) : base(zainServices)
        {
            _inventoryQueryRepository = inventoryQueryRepository;
        }

        public override async Task<QueryResult<InventoryQr>> Handle(GetInventoryByIdQuery query)
        {
            var inventroty = await _inventoryQueryRepository.ExecuteAsync(query);
            return Result(inventroty);
        }
    }
}
