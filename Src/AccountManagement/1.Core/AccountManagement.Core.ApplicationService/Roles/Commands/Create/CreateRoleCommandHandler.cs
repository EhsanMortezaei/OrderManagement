using AccountManagement.Core.Contract.Roles.Commands;
using AccountManagement.Core.Domain.Roles.Entities;
using AccountManagement.Core.RequestResponse.Roles.Commands.Create;
using Framework.ErrorMessages;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace AccountManagement.Core.ApplicationService.Roles.Commands.Create;

public sealed class CreateRoleCommandHandler(ZaminServices zaminServices,
    IRoleCommandRepository roleCommandRepository) : CommandHandler<CreateRoleCommand, Guid>(zaminServices)
{
    public override async Task<CommandResult<Guid>> Handle(CreateRoleCommand command)
    {
        if (await roleCommandRepository.ExistsAsync(c => c.Name == command.Name))
            throw new InvalidEntityStateException(ErrorMessage.DuplicateRoleName);

        var role = new Role(command.Name);

        await roleCommandRepository.InsertAsync(role);
        await roleCommandRepository.CommitAsync();

        return Ok(role.BusinessId.Value);
    }
}
