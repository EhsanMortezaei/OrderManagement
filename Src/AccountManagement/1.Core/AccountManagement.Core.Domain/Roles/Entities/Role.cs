using AccountManagement.Core.Domain.Roles.Events;
using Zamin.Core.Domain.Entities;

namespace AccountManagement.Core.Domain.Roles.Entities;

public sealed class Role : AggregateRoot<int>
{
    public string Name { get;  set; } = null!;
     List<Permission> _permissions = [];

     Role() { }

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

    //public void AddPermission(int permissionId)
    //{
        //if(_permissions.Exists(c=>c.per)
    //}
}
