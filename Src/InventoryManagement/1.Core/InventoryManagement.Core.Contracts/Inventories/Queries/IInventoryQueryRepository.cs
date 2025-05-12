using InventoryManagement.Core.RequestResponse.Inventories.Queries;

namespace InventoryManagement.Core.Contracts.Inventories.Queries;

public interface IInventoryQueryRepository
{
    public Task<InventoryQr?> ExecuteAsync(GetInventoryByIdQuery query);
}
