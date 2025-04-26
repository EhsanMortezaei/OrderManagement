using InventoryManagement.Core.Contracts.InventoryOperations.Queries;
using InventoryManagement.Core.RequestResponse.InventoryOperations.Queries;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.RequestResponse.Queries;
using Zamin.Utilities;

namespace InventoryManagement.Core.ApplicationService.InventoryOperations.Queries.GetById
{
    public class GetInventoryOperationByIdQueryHandler : QueryHandler<GetInventoryOperationByIdQuery, InventiryOperationQr>
    {
        private readonly IInventoryOperationsQueryRepository _inventoryOperationsQueryRepository;

        public GetInventoryOperationByIdQueryHandler(ZaminServices zaminServices,
            IInventoryOperationsQueryRepository inventoryOperationsQueryRepository) : base(zaminServices)
        {
            _inventoryOperationsQueryRepository = inventoryOperationsQueryRepository;
        }

        public override async Task<QueryResult<InventiryOperationQr>> Handle(GetInventoryOperationByIdQuery query)
        {
            var inventoryOperation = await _inventoryOperationsQueryRepository.ExecuteAsync(query);
            return Result(inventoryOperation);
        }
    }
}
