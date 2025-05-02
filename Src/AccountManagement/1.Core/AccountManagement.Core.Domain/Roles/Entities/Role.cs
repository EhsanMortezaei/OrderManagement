using AccountManagement.Core.Domain.Accounts.Entities;
using AccountManagement.Core.Domain.Permissions.Entities;
using AccountManagement.Core.Domain.Roles.Events;
using System.Security;
using Zamin.Core.Domain.Entities;

namespace AccountManagement.Core.Domain.Roles.Entities
{
    public class Role : AggregateRoot<int>
    {
        public string Name { get; private set; }
        public List<Permission> Permissions { get; private set; }

        protected Role()
        {
        }

        public Role(string name)
        {
            Name = name;
            AddEvent(new RoleCreated(BusinessId.Value, Name));
        }

        public void Edite(string name)
        {
            Name = name;
        }
    }
}
