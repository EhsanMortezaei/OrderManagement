using Zamin.Core.RequestResponse.Commands;
using Zamin.Core.RequestResponse.Endpoints;

namespace AccountManagement.Core.RequestResponse.Permissions.Commands.Create
{
    public class CreatePermissionCommand : ICommand<Guid>, IWebRequest
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public int RoleId { get; set; }
        public int AccountId { get; set; }
        public string Path => "/api/Permission/Create";
    }
}
