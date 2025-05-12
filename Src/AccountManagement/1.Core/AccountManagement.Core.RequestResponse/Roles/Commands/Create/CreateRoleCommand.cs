using Zamin.Core.RequestResponse.Commands;

namespace AccountManagement.Core.RequestResponse.Roles.Commands.Create;

public sealed class CreateRoleCommand : ICommand<Guid>
{
    public string Name { get; set; } = string.Empty;
}
