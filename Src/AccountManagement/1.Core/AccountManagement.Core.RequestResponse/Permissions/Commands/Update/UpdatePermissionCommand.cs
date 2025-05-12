using Zamin.Core.RequestResponse.Commands;

namespace AccountManagement.Core.RequestResponse.Permissions.Commands.Update;

public sealed class UpdatePermissionCommand : ICommand
{
    public int Id { get; set; }
    public int Code { get; set; }
    public string Name { get; set; } = string.Empty;
    public int RoleId { get; set; }
    public int AccountId { get; set; }
}
