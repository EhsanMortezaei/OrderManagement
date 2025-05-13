using AccountManagement.Core.Domain.Accounts.Entities;
using AccountManagement.Core.Domain.Roles.Events;
using Zamin.Core.Domain.Entities;
using Zamin.Core.Domain.Exceptions;

namespace AccountManagement.Core.Domain.Roles.Entities;

public sealed class Role : AggregateRoot<int>
{
    public string Name { get; private set; } = null!;
    List<Permission> _permissions = [];
    public IReadOnlyList<Permission> Permissions => _permissions;

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

    public void AddPermission(int permissionId)
    {
        if (_permissions.Any(p => p.Id == permissionId))
            throw new InvalidEntityStateException("این پرمیشن قبلاً اضافه شده است");



        _permissions.Add(new Permission(permissionId));
    }

    public void RemovePermission(int permissionId)
    {
        var permission = _permissions.FirstOrDefault(x => x.Id == permissionId);

        if (permission is null)
            throw new InvalidEntityStateException("Permission پیدا نشد");
        _permissions.Remove(permission);
    }
}