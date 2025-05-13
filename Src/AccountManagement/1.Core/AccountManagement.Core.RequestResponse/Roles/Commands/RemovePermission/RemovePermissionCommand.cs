using Zamin.Core.RequestResponse.Commands;

namespace AccountManagement.Core.RequestResponse.Roles.Commands.RemovePermission;

public sealed class RemovePermissionCommand : ICommand
{
    public int PermissionId { get; set; }
    public int RoleId { get; set; }
}
