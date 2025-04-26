using Zamin.Core.RequestResponse.Endpoints;
using Zamin.Core.RequestResponse.Queries;

namespace AccountManagement.Core.RequestResponse.Accounts.Queries
{
    public class GetAccountByIdQuery : IQuery<AccountQr?>, IWebRequest
    {
        public int AccountId { get; set; }
        public string Path => "/api/Account/GetById";
    }
}
