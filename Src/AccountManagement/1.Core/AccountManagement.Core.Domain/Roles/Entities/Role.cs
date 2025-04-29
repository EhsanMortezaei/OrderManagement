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
        //public List<Account> Accounts { get; private set; }

        protected Role()
        {
        }

        public Role(string name, List<Permission> permissions)
        {
            Name = name;
            Permissions = permissions;
            //Accounts = new List<Account>();
            AddEvent(new RoleCreated(BusinessId.Value, Name, Permissions));
        }

        public void Edite(string name, List<Permission> permissions)
        {
            Name = name;
            Permissions = permissions;
        }
    }
}
