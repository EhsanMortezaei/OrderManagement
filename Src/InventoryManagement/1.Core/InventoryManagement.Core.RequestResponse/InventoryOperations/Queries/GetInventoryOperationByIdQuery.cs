using Zamin.Core.RequestResponse.Endpoints;
using Zamin.Core.RequestResponse.Queries;

namespace InventoryManagement.Core.RequestResponse.InventoryOperations.Queries
{
    public class GetInventoryOperationByIdQuery : IQuery<InventiryOperationQr?>, IWebRequest
    {
        public int InventoryOperationId { get; set; }
        public string Path => "/api/InventoryOperation/GetById";
    }
}
