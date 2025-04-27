using InventoryManagement.Core.RequestResponse.InventoryOperations.Queries;
using ShopManagement.Core.RequestResponse.OrderItems.Queries;

namespace InventoryManagement.Core.Contracts.InventoryOperations.Queries
{
    public interface IInventoryOperationsQueryRepository
    {
        public Task<InventoryOperationQr> ExecuteAsync(GetInventoryOperationByIdQuery query);
    }
}
