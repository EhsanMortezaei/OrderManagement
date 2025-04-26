using Zamin.Core.RequestResponse.Commands;
using Zamin.Core.RequestResponse.Endpoints;

namespace AccountManagement.Core.RequestResponse.Roles.Commands.Delete
{
    public class DeleteRoleCommand : ICommand, IWebRequest
    {
        public int Id { get; set; }
        public string Path => "/api/Role/Delete";
    }
}
