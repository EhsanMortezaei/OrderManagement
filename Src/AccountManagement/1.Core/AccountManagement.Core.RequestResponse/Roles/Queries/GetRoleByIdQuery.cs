using Zamin.Core.RequestResponse.Endpoints;
using Zamin.Core.RequestResponse.Queries;

namespace AccountManagement.Core.RequestResponse.Roles.Queries
{
    public class GetRoleByIdQuery : IQuery<RoleQr?>, IWebRequest
    {
        public int RoleId { get; set; }
        public string Path => "/api/Role/GetById";
    }
}
