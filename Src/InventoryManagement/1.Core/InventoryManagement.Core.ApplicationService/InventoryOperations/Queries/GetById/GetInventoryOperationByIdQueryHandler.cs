using InventoryManagement.Core.Contracts.InventoryOperations.Queries;
using InventoryManagement.Core.RequestResponse.InventoryOperations.Queries;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.RequestResponse.Queries;
using Zamin.Utilities;

namespace InventoryManagement.Core.ApplicationService.InventoryOperations.Queries.GetById;

public sealed class GetInventoryOperationByIdQueryHandler(ZaminServices zaminServices,
    IInventoryOperationsQueryRepository inventoryOperationsQueryRepository) : QueryHandler<GetInventoryOperationByIdQuery, InventoryOperationQr?>(zaminServices)
{
    public override async Task<QueryResult<InventoryOperationQr?>> Handle(GetInventoryOperationByIdQuery query)
    {
        return Result(await inventoryOperationsQueryRepository.ExecuteAsync(query));
    }
}
