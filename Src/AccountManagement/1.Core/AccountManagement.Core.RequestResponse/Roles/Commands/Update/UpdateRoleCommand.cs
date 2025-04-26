using AccountManagement.Core.Domain.Roles.Entities;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Core.RequestResponse.Endpoints;

namespace AccountManagement.Core.RequestResponse.Roles.Commands.Update
{
    public class UpdateRoleCommand : ICommand, IWebRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Permission> Permissions { get; set; }
        public string Path => "/api/Role/Update";
    }
}
