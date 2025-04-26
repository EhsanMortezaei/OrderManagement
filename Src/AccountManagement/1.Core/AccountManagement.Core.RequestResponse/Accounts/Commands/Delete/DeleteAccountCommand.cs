using Zamin.Core.RequestResponse.Commands;
using Zamin.Core.RequestResponse.Endpoints;

namespace AccountManagement.Core.RequestResponse.Accounts.Commands.Delete
{
    public class DeleteAccountCommand :ICommand,IWebRequest
    {
        public int Id { get; set; }
        public string Path => "/api/Account/Delete";
    }
}
