using AccountManagement.Core.Contract.Roles.Commands;
using AccountManagement.Core.RequestResponse.Roles.Commands.Delete;
using Framework.ErrorMessages;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace AccountManagement.Core.ApplicationService.Roles.Commands.Delete;

public sealed class DeleteRoleCommandHandler(ZaminServices zaminServices,
    IRoleCommandRepository roleCommandRepository) : CommandHandler<DeleteRoleCommand>(zaminServices)
{
    public override async Task<CommandResult> Handle(DeleteRoleCommand command)
    {
        var role = await roleCommandRepository.GetGraphAsync(command.Id)
            ?? throw new InvalidEntityStateException(ErrorMessage.NotAccount);

        roleCommandRepository.Delete(role);
        await roleCommandRepository.CommitAsync();

        return Ok();
    }
}
