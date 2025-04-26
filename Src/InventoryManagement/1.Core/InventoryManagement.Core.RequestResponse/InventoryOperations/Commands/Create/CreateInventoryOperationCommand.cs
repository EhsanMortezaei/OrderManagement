using Zamin.Core.RequestResponse.Commands;
using Zamin.Core.RequestResponse.Endpoints;

namespace InventoryManagement.Core.RequestResponse.InventoryOperations.Commands.Create
{
    public class CreateInventoryOperationCommand : ICommand<Guid>, IWebRequest
    {
        public bool Operation { get; set; }
        public long Count { get; set; }
        public long OperatorId { get; set; }
        public DateTime OperationDate { get; set; }
        public long CurrentCount { get; set; }
        public string Description { get; set; }
        public long OrderId { get; set; }
        public long InventoryId { get; set; }
        public string Path => "/api/InventoryOperation/Create";
    }
}
