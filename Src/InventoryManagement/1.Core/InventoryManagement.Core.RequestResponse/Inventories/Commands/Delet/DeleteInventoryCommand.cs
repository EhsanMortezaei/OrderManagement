using Zamin.Core.RequestResponse.Commands;
using Zamin.Core.RequestResponse.Endpoints;

namespace InventoryManagement.Core.RequestResponse.Inventories.Commands.Delet
{
    public class DeleteInventoryCommand : ICommand, IWebRequest
    {
        public int Id { get; set; }
        public string Path => "/api/Inventory/Delete";
    }
}
