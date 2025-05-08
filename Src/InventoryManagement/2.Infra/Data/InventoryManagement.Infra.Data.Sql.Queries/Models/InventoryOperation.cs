namespace InventoryManagement.Infra.Data.Sql.Queries.Models;

public partial class InventoryOperation
{
    public long Id { get; set; }

    public bool Operation { get; set; }

    public long Count { get; set; }

    public long OperatorId { get; set; }

    public DateTime OperationDate { get; set; }

    public long CurrentCount { get; set; }

    public string Description { get; set; } = null!;

    public long OrderId { get; set; }

    public long InventoryId { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public int? InventoryId1 { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? ModifiedDateTime { get; set; }

    public Guid BusinessId { get; set; }

    public virtual Inventory? InventoryId1Navigation { get; set; }
}
