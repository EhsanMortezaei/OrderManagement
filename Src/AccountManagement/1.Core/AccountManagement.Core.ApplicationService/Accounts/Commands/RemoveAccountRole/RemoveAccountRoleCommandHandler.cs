using AccountManagement.Core.Contract.Accounts.Commands;
using AccountManagement.Core.RequestResponse.Accounts.Commands.RemoveAccountRole;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace AccountManagement.Core.ApplicationService.Accounts.Commands.RemoveAccountRole;

public sealed class RemoveAccountRoleCommandHandler : CommandHandler<RemoveAccountRoleCommand>
{
    private readonly IAccountCommandRepository _accountCommandRepository;

    public RemoveAccountRoleCommandHandler(ZaminServices zaminServices,
        IAccountCommandRepository accountCommandRepository) : base(zaminServices)
    {
        _accountCommandRepository = accountCommandRepository;
    }

    public async override Task<CommandResult> Handle(RemoveAccountRoleCommand command)
    {
        var accountRole = await _accountCommandRepository.GetGraphAsync(command.AccountId);
        if (accountRole is null || command.AccountId <= 0)
            throw new InvalidEntityStateException("رول یا اکانت یافت نشد");

        accountRole.RemoveRole(command.RoleId);

        await _accountCommandRepository.CommitAsync();
        return Ok();
    }
}
