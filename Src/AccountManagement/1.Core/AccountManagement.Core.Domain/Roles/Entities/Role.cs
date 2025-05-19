using Framework.ErrorMessages;
using Zamin.Core.Domain.Entities;
using Zamin.Core.Domain.Exceptions;

namespace AccountManagement.Core.Domain.Roles.Entities;

public sealed class Role : AggregateRoot<int>
{
    #region Properties
    public string Name { get; private set; } = null!;
    private readonly List<Permission> _permissions = [];
    public IReadOnlyList<Permission> Permissions => _permissions;
    #endregion

    #region Constructors
    private Role() { }

    public Role(string name) => Name = name;
    #endregion

    #region Commands
    public static Role Create(string name) => new Role(name);

    public void Edite(string name)
    {
        Name = name;
    }

    public void AddPermission(int permissionId)
    {
        if (_permissions.Any(p => p.Id == permissionId))
            throw new InvalidEntityStateException(ErrorMessage.Permission);

        _permissions.Add(new Permission(permissionId));
    }

    public void RemovePermission(int permissionId)
    {
        var permission = _permissions.FirstOrDefault(x => x.Id == permissionId)
            ?? throw new InvalidEntityStateException(ErrorMessage.Permission);
        _permissions.Remove(permission);
    }
    #endregion
}