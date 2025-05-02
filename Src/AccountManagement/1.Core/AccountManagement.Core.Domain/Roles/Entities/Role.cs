using AccountManagement.Core.Domain.Roles.Events;
using Zamin.Core.Domain.Entities;

namespace AccountManagement.Core.Domain.Roles.Entities
{
    public class Role : AggregateRoot<int>
    {
        public string Name { get; private set; }


        protected Role() { }

        public Role(string name)
        {
            Name = name;
            AddEvent(new RoleCreated(BusinessId.Value, Name));
        }

        public static Role Create(string name) => new Role(name);

        public void Edite(string name)
        {
            Name = name;
        }
    }
}
