using AccountManagement.Core.Contract.Roles.Commands;
using AccountManagement.Core.RequestResponse.Roles.Commands.AddPermission;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace AccountManagement.Core.ApplicationService.Roles.Commands.AddPermission;

public sealed class AddPermissionCommandHandler(ZaminServices zaminServices,
    IRoleCommandRepository roleCommandRepository) : CommandHandler<AddPermissionCommand>(zaminServices)
{
    public override async Task<CommandResult> Handle(AddPermissionCommand command)
    {
        var permission = await roleCommandRepository.GetGraphAsync(command.RoleId);
        permission.AddPermission(command.Code);
        await roleCommandRepository.CommitAsync();
        return Ok();
    }
}
