using Zamin.Core.RequestResponse.Commands;
using Zamin.Core.RequestResponse.Endpoints;

namespace InventoryManagement.Core.RequestResponse.Inventories.Commands.ReduceInventory
{
    public class ReduceInventoryCommand : ICommand<Guid>, IWebRequest
    {
        public int InventoryId { get; set; }
        public int ProductId { get; set; }
        public long Count { get; set; }
        public string Description { get; set; }
        public int OrderId { get; set; }
        public string Path => "/api/Inventory/Reduce";


        public ReduceInventoryCommand()
        {

        }

        public ReduceInventoryCommand(int productId, int count, string description, int orderId)
        {
            ProductId = productId;
            Count = count;
            Description = description;
            OrderId = orderId;
        }
    }
}
