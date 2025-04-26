using Zamin.Core.RequestResponse.Endpoints;
using Zamin.Core.RequestResponse.Queries;

namespace InventoryManagement.Core.RequestResponse.Inventories.Queries
{
    public class GetInventoryByIdQuery : IQuery<InventoryQr?>, IWebRequest
    {
        public int InventoryId { get; set; }
        public string Path => "/api/Inventory/GetById";
    }
}
