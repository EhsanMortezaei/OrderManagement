using Zamin.Core.RequestResponse.Queries;

namespace InventoryManagement.Core.RequestResponse.Inventories.Queries;

public sealed class GetInventoryByIdQuery : IQuery<InventoryQr?>
{
    public int InventoryId { get; set; }
}
