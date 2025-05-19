using Zamin.Core.Domain.Entities;

namespace AccountManagement.Core.Domain.Roles.Entities;

/// <summary>
///  entity shavad
/// </summary>
public sealed class Permission : Entity<int>
{
    #region Properties
    public int Code { get; private set; }
    public string Name { get; private set; } = null!;
    public int RoleId { get; private set; }
    #endregion

    #region Constructors
    private Permission() { }

    public Permission(int permissionId) => Id = permissionId;

    public Permission(int code, string name, int roleId)
    {
        Code = code;
        Name = name;
        RoleId = roleId;
    }
    #endregion

    #region Commands
    public static Permission Create(int code, string name, int roleId)
        => new(code, name, roleId);

    public void Edit(int code, string name)
    {
        Code = code;
        Name = name;
    }
    #endregion
}
