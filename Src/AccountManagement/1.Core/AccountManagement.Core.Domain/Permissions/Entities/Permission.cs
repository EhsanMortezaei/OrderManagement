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

        protected Permission() { }

        public Permission(int code, string name)
        {
            Code = code;
            Name = name;
        }

        public Permission(int code, string name, int roleId)
        {
            Code = code;
            Name = name;
            RoleId = roleId;
            AddEvent(new PermissionCreated(BusinessId.Value, Code, Name));
        }

        public static Permission Create(int code, string name, int roleId)
            => new Permission(code, name, roleId);

        public void Edit(int code, string name)
        {
            Code = code;
            Name = name;
        }
    }
}
