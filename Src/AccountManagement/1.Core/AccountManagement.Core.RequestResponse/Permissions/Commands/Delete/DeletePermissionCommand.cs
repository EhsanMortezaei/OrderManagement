using Zamin.Core.RequestResponse.Commands;
using Zamin.Core.RequestResponse.Endpoints;

namespace AccountManagement.Core.RequestResponse.Permissions.Commands.Delete
{
    public class DeletePermissionCommand : ICommand, IWebRequest
    {
        public int Id { get; set; }
        public string Path => "/api/Permission/Delete";
    }
}
