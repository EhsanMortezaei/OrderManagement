using Zamin.Core.RequestResponse.Queries;

namespace InventoryManagement.Core.RequestResponse.InventoryOperations.Queries;

public sealed class GetInventoryOperationByIdQuery : IQuery<InventoryOperationQr?>
{
    public int InventoryOperationId { get; set; }
}
