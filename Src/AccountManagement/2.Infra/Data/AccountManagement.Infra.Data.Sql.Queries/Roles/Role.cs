using AccountManagement.Core.Domain.Permissions.Entities;

namespace AccountManagement.Infra.Data.Sql.Queries.Roles
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Permission> Permissions { get; set; }
    }
}
