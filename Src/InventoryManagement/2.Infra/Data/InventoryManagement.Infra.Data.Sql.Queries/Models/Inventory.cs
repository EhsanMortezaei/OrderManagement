namespace InventoryManagement.Infra.Data.Sql.Queries.Models;

public partial class Inventory
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public double UnitPrice { get; set; }

    public bool InStock { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? ModifiedDateTime { get; set; }

    public Guid BusinessId { get; set; }

    public virtual ICollection<InventoryOperation> InventoryOperations { get; set; } = new List<InventoryOperation>();
}
