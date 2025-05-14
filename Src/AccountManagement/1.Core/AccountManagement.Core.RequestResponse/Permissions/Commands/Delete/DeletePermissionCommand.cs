using Zamin.Core.RequestResponse.Commands;

namespace AccountManagement.Core.RequestResponse.Permissions.Commands.Delete;

public sealed class DeletePermissionCommand : ICommand
{
    public int Id { get; set; }
}