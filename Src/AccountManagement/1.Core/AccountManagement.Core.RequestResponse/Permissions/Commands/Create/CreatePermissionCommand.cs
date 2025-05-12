using Zamin.Core.RequestResponse.Commands;

namespace AccountManagement.Core.RequestResponse.Permissions.Commands.Create;

public sealed class CreatePermissionCommand : ICommand<Guid>
{
    public int Code { get; set; }
    public string Name { get; set; } = string.Empty;
    public int RoleId { get; set; }
    public int AccountId { get; set; }
}
