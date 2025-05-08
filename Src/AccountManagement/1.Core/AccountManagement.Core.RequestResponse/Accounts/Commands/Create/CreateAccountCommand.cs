using Zamin.Core.RequestResponse.Commands;
using Zamin.Core.RequestResponse.Endpoints;

namespace AccountManagement.Core.RequestResponse.Accounts.Commands.Create
{
    public class CreateAccountCommand : ICommand<Guid>, IWebRequest
    {
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
        public string ProfilePhoto { get; set; }
        public string Path => "/api/Account/Create";
    }
}
