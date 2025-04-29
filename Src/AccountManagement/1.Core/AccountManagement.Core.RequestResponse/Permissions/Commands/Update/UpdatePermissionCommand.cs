using Zamin.Core.RequestResponse.Commands;
using Zamin.Core.RequestResponse.Endpoints;

namespace AccountManagement.Core.RequestResponse.Permissions.Commands.Update
{
    public class UpdatePermissionCommand : ICommand, IWebRequest
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public int RoleId { get; set; }
        public int AccountId { get; set; }
        public string Path => "/api/Permission/Update";
    }
}
