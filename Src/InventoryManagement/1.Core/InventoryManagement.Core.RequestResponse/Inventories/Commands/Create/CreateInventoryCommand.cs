using InventoryManagement.Core.Domain.Inventories.Entities;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Core.RequestResponse.Endpoints;

namespace InventoryManagement.Core.RequestResponse.Inventories.Commands.Create
{
    public class CreateInventoryCommand : ICommand<Guid>, IWebRequest
    {
        public int ProductId { get; set; }
        public double UnitPrice { get; set; }
        public List<InventoryOperation> Operations { get; set; }
        public bool InStock { get; set; }
        public string Path => "/api/Inventory/Create";
    }
}
