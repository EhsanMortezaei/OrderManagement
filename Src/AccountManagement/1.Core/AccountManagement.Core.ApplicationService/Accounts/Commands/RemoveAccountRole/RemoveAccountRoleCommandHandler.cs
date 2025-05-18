using AccountManagement.Core.Contract.Accounts.Commands;
using AccountManagement.Core.RequestResponse.Accounts.Commands.RemoveAccountRole;
using Framework.Enums.Validation;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace AccountManagement.Core.ApplicationService.Accounts.Commands.RemoveAccountRole;

public sealed class RemoveAccountRoleCommandHandler(ZaminServices zaminServices,
    IAccountCommandRepository accountCommandRepository) : CommandHandler<RemoveAccountRoleCommand>(zaminServices)
{
    public async override Task<CommandResult> Handle(RemoveAccountRoleCommand command)
    {
        var accountRole = await accountCommandRepository.GetGraphAsync(command.AccountId)
            ?? throw new InvalidEntityStateException(ErrorMessages.Get(ErrorMessageKey.RoleError));
        accountRole.RemoveRole(command.RoleId);

        await accountCommandRepository.CommitAsync();
        return Ok();
    }
}
