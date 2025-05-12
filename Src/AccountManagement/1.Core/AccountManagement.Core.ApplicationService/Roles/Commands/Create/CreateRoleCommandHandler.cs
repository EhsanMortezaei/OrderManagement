using AccountManagement.Core.Contract.Roles.Commands;
using AccountManagement.Core.Domain.Roles.Entities;
using AccountManagement.Core.RequestResponse.Roles.Commands.Create;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace AccountManagement.Core.ApplicationService.Roles.Commands.Create;

public sealed class CreateRoleCommandHandler : CommandHandler<CreateRoleCommand, Guid>
{
     readonly IRoleCommandRepository _roleCommandRepository;

    public CreateRoleCommandHandler(ZaminServices zaminServices,
        IRoleCommandRepository roleCommandRepository) : base(zaminServices)
    {
        _roleCommandRepository = roleCommandRepository;
    }

    public override async Task<CommandResult<Guid>> Handle(CreateRoleCommand command)
    {
        var role = new Role(command.Name);

        await _roleCommandRepository.InsertAsync(role);
        await _roleCommandRepository.CommitAsync();

        return Ok(role.BusinessId.Value);
    }
}
