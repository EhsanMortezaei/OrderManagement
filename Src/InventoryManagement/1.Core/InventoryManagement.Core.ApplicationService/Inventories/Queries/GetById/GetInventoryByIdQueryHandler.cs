using InventoryManagement.Core.Contracts.Inventories.Queries;
using InventoryManagement.Core.RequestResponse.Inventories.Queries;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.RequestResponse.Queries;
using Zamin.Utilities;

namespace InventoryManagement.Core.ApplicationService.Inventories.Queries.GetById;

public sealed class GetInventoryByIdQueryHandler(ZaminServices zainServices,
    IInventoryQueryRepository inventoryQueryRepository) : QueryHandler<GetInventoryByIdQuery, InventoryQr?>(zainServices)
{
    public override async Task<QueryResult<InventoryQr?>> Handle(GetInventoryByIdQuery query)
        => Result(await inventoryQueryRepository.ExecuteAsync(query));
}
