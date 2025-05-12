using Zamin.Core.RequestResponse.Commands;

namespace AccountManagement.Core.RequestResponse.Roles.Commands.Update;

public sealed class UpdateRoleCommand : ICommand
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}
