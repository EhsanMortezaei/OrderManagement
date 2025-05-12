using Zamin.Core.RequestResponse.Commands;

namespace AccountManagement.Core.RequestResponse.Roles.Commands.Delete;

public sealed class DeleteRoleCommand : ICommand
{
    public int Id { get; set; }
}
