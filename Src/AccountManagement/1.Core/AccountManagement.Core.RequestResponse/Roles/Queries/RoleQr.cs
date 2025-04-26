using AccountManagement.Core.Domain.Roles.Entities;

namespace AccountManagement.Core.RequestResponse.Roles.Queries
{
    public class RoleQr
    {
        public string Name { get; set; }
        public List<Permission> Permissions { get; set; }
    }
}
