using AccountManagement.Core.Contract.Roles.Commands;
using AccountManagement.Core.RequestResponse.Roles.Commands.Update;
using Framework.Enums.Validation;
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
        var role = await roleCommandRepository.GetAsync(command.Id);
        if (role is null)
            throw new InvalidEntityStateException(ErrorMessages.Get(ErrorMessageKey.NotAccount));

        role.Edite(command.Name);
        await roleCommandRepository.CommitAsync();
        return Ok();
    }
}
