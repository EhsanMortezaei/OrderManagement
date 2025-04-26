using Zamin.Core.RequestResponse.Commands;
using Zamin.Core.RequestResponse.Endpoints;

namespace InventoryManagement.Core.RequestResponse.Inventories.Commands.Update
{
    public class UpdateInventoryCommand : ICommand, IWebRequest
    {
        public int Id { get; set; }
        public long ProductId { get; set; }
        public double UnitPrice { get; set; }
        public bool InStock { get; set; }
        public string Path => "/api/Inventory/Update";
    }
}
