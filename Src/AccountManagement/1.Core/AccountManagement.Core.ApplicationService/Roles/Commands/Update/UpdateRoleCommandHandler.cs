using AccountManagement.Core.Contract.Roles.Commands;
using AccountManagement.Core.RequestResponse.Roles.Commands.Update;
using Framework.ErrorMessages;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace AccountManagement.Core.ApplicationService.Roles.Commands.Update;

public sealed class UpdateRoleCommandHandler(ZaminServices zaminServices,
    IRoleCommandRepository roleCommandRepository) : CommandHandler<UpdateRoleCommand>(zaminServices)
{
    public override async Task<CommandResult> Handle(UpdateRoleCommand command)
    {
        if (await roleCommandRepository.ExistsAsync(r => r.Name == command.Name))
            throw new InvalidEntityStateException(ErrorMessage.DuplicateRoleName);

        var role = await roleCommandRepository.GetAsync(command.Id)
            ?? throw new InvalidEntityStateException(ErrorMessage.NotAccount);

        role.Edite(command.Name);
        await roleCommandRepository.CommitAsync();
        return Ok();
    }
}
