using AccountManagement.Core.Domain.Permissions.Entities;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Core.RequestResponse.Endpoints;

namespace AccountManagement.Core.RequestResponse.Roles.Commands.Create
{
    public class CreateRoleCommand : ICommand<Guid>, IWebRequest
    {
        public string Name { get; set; }
        public string Path => "/api/Role/Create";
    }
}
