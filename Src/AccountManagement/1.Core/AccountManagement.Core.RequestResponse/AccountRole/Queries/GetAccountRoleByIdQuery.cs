using Zamin.Core.RequestResponse.Endpoints;
using Zamin.Core.RequestResponse.Queries;

namespace AccountManagement.Core.RequestResponse.AccountRole.Queries
{
    public class GetAccountRoleByIdQuery : IQuery<AccountRoleQr?>, IWebRequest
    {
        public int AccountRoleId { get; set; }
        public string Path => "/api/Account/GetById";
    }
}
