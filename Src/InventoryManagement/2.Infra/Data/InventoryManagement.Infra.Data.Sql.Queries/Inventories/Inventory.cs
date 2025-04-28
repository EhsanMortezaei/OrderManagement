namespace InventoryManagement.Infra.Data.Sql.Queries.Inventories
{
    public class Inventory
    {
        public int Id { get; set; }
        public long ProductId { get; set; }
        public double UnitPrice { get; set; }
        public bool InStock { get; set; }
    }
}
