using AccountManagement.Core.Contract.Roles.Commands;
using AccountManagement.Core.RequestResponse.Roles.Commands.RemovePermission;
using Framework.ErrorMessages;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace AccountManagement.Core.ApplicationService.Roles.Commands.RemovePermission;

public sealed class RemovePermissionCommandHandler(ZaminServices zaminServices,
    IRoleCommandRepository roleCommandRepository) : CommandHandler<RemovePermissionCommand>(zaminServices)
{
    public override async Task<CommandResult> Handle(RemovePermissionCommand command)
    {
        var role = await roleCommandRepository.GetGraphAsync(command.RoleId)
            ?? throw new InvalidEntityStateException(ErrorMessage.NotAccount);
        role.RemovePermission(command.PermissionId);
        return Ok();
    }
}
