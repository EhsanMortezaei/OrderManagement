namespace InventoryManagement.Core.RequestResponse.Inventories.Queries;

public sealed class InventoryQr
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public double UnitPrice { get; set; }
    public bool InStock { get; set; }
}
