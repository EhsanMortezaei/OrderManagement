using InventoryManagement.Core.Contracts.Inventories.Queries;
using InventoryManagement.Core.RequestResponse.Inventories.Queries;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.RequestResponse.Queries;
using Zamin.Utilities;

namespace InventoryManagement.Core.ApplicationService.Inventories.Queries.GetById;

public sealed class GetInventoryByIdQueryHandler : QueryHandler<GetInventoryByIdQuery, InventoryQr?>
{
     readonly IInventoryQueryRepository _inventoryQueryRepository;

    public GetInventoryByIdQueryHandler(ZaminServices zainServices,
        IInventoryQueryRepository inventoryQueryRepository) : base(zainServices)
    {
        _inventoryQueryRepository = inventoryQueryRepository;
    }

    public override async Task<QueryResult<InventoryQr?>> Handle(GetInventoryByIdQuery query)
        => Result(await _inventoryQueryRepository.ExecuteAsync(query));
}
