using Zamin.Core.RequestResponse.Commands;
using Zamin.Core.RequestResponse.Endpoints;

namespace InventoryManagement.Core.RequestResponse.InventoryOperations.Commands.Delete
{
    public class DeleteInventoryOperationCommand : ICommand, IWebRequest
    {
        public int Id { get; set; }
        public string Path => "/api/InventoryOperation/Delete";
    }
}
