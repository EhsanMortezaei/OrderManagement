using Zamin.Core.RequestResponse.Commands;
using Zamin.Core.RequestResponse.Endpoints;

namespace InventoryManagement.Core.RequestResponse.Inventories.Commands.IncreaseInventory
{
    public class IncreaseInventoryCommand : ICommand<Guid>, IWebRequest
    {
        public int InventoryId { get; set; }
        public long Count { get; set; }
        public string Description { get; set; }
        public string Path => "/api/Inventory/Increase";

    }
}
