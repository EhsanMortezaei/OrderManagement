using AccountManagement.Core.Contract.Roles.Commands;
using AccountManagement.Core.RequestResponse.Roles.Commands.AddPermission;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace AccountManagement.Core.ApplicationService.Roles.Commands.AddPermission;

public sealed class AddPermissionCommandHandler : CommandHandler<AddPermissionCommand>
{
    private readonly IRoleCommandRepository _roleCommandRepository;

    public AddPermissionCommandHandler(ZaminServices zaminServices,
        IRoleCommandRepository roleCommandRepository) : base(zaminServices)
    {
        _roleCommandRepository = roleCommandRepository;
    }

    public override async Task<CommandResult> Handle(AddPermissionCommand command)
    {
        var permission = await _roleCommandRepository.GetGraphAsync(command.RoleId);
        permission.AddPermission(command.Code);
        await _roleCommandRepository.CommitAsync();
        return Ok();
    }
}
