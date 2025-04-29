using AccountManagement.Core.Domain.Permissions.Event;
using Zamin.Core.Domain.Entities;

namespace AccountManagement.Core.Domain.Permissions.Entities
{
    public class Permission : AggregateRoot<int>
    {
        public int Id { get; private set; }
        public int Code { get; private set; }
        public string Name { get; private set; }
        public int RoleId { get; private set; }
        public int AccountId { get; private set; }

        //public Role Role { get; private set; }

        public Permission(int code)
        {
            Code = code;
        }

        public Permission(int code, string name)
        {
            Code = code;
            Name = name;
            AddEvent(new PermissionCreated(BusinessId.Value, Code, Name));
        }

        public void Edit(int code, string name)
        {
            Code = code;
            Name = name;
        }
    }
}
