using Zamin.Core.Domain.Entities;

namespace AccountManagement.Core.Domain.Roles.Entities;

/// <summary>
///  entity shavad
/// </summary>
public sealed class Permission : Entity<int>
{
    public int Code { get; set; }
    public string Name { get; set; } = null!;
    public int RoleId { get; set; }

    Permission() { }

    public Permission(int permissionId)
    {
        Id = permissionId;
    }

    public Permission(int code, string name, int roleId)
    {
        Code = code;
        Name = name;
        RoleId = roleId;
    }

    public static Permission Create(int code, string name, int roleId)
        => new Permission(code, name, roleId);

    public void Edit(int code, string name)
    {
        Code = code;
        Name = name;
    }
}
