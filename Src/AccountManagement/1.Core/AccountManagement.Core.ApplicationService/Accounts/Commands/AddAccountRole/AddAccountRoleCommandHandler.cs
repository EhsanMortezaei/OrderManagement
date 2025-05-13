using AccountManagement.Core.Contract.Accounts.Commands;
using AccountManagement.Core.RequestResponse.Accounts.Commands.AddAccountRole;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace AccountManagement.Core.ApplicationService.Accounts.Commands.AddAccountRole;

public sealed class AddAccountRoleCommandHandler(ZaminServices zaminServices,
    IAccountCommandRepository accountCommandRepository) : CommandHandler<AddAccountRoleCommand>(zaminServices)
{
    public override async Task<CommandResult> Handle(AddAccountRoleCommand command)
    {
        var accountRole = await accountCommandRepository.GetGraphAsync(command.AccountId);

        accountRole.AddRole(command.RoleId);

        await accountCommandRepository.CommitAsync();

        return Ok();

    }
}
