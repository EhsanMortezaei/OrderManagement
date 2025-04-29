using Zamin.Core.RequestResponse.Endpoints;
using Zamin.Core.RequestResponse.Queries;

namespace AccountManagement.Core.RequestResponse.Permissions.Queries
{
    public class GetPermissionByIdQuery : IQuery<PermissionQr>, IWebRequest
    {
        public int PermissionId { get; set; }
        public string Path => "/api/Account/GetById";
    }
}
