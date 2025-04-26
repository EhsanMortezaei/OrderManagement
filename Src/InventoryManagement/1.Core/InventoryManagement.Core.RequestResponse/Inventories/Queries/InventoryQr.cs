namespace InventoryManagement.Core.RequestResponse.Inventories.Queries
{
    public class InventoryQr
    {
        public long ProductId { get; set; }
        public double UnitPrice { get; set; }
        public bool InStock { get; set; }
    }
}
