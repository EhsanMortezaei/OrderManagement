using Zamin.Core.RequestResponse.Commands;

namespace AccountManagement.Core.RequestResponse.Roles.Commands.AddPermission;

public sealed class AddPermissionCommand : ICommand
{
    public int Code { get; set; }
    public string Name { get; set; } = null!;
    public int RoleId { get; set; }
}
