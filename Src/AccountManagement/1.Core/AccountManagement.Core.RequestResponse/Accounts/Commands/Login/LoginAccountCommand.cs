using Zamin.Core.RequestResponse.Commands;
using Zamin.Core.RequestResponse.Endpoints;

namespace AccountManagement.Core.RequestResponse.Accounts.Commands.Login
{
    public class LoginAccountCommand : ICommand<Guid>, IWebRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Path => "/api/Account/Login";
    }
}
