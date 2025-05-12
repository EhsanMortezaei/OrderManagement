using Zamin.Core.RequestResponse.Commands;

namespace InventoryManagement.Core.RequestResponse.InventoryOperations.Commands.Create;

public sealed class CreateInventoryOperationCommand : ICommand<Guid>
{
    public bool Operation { get; set; }
    public long Count { get; set; }
    public long OperatorId { get; set; }
    public DateTime OperationDate { get; set; }
    public long CurrentCount { get; set; }
    public string Description { get; set; } = string.Empty;
    public long OrderId { get; set; }
    public long InventoryId { get; set; }
}
