using AccountManagement.Core.Domain.Permissions.Entities;

namespace AccountManagement.Core.RequestResponse.Roles.Queries
{
    public class RoleQr
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Permission> Permissions { get; set; }
    }
}
