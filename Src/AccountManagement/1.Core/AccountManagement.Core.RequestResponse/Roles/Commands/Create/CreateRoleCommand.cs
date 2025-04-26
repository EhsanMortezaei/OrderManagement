using AccountManagement.Core.Domain.Roles.Entities;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Core.RequestResponse.Endpoints;

namespace AccountManagement.Core.RequestResponse.Roles.Commands.Create
{
    public class CreateRoleCommand : ICommand<Guid>, IWebRequest
    {
        public string Name { get; private set; }
        public List<Permission> Permissions { get; private set; }
        public string Path => "/api/Role/Create";
    }
}
