using AccountManagement.Core.Contract.Accounts.Commands;
using AccountManagement.Core.RequestResponse.Accounts.Commands.Delete;
using Framework.Enums.Validation;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace AccountManagement.Core.ApplicationService.Accounts.Commands.Delete;

public class DeleteAccountCommandHandler(ZaminServices zaminServices,
    IAccountCommandRepository accountCommandRepository) : CommandHandler<DeleteAccountCommand>(zaminServices)
{
    readonly IAccountCommandRepository _accountCommandRepository = accountCommandRepository;

    public override async Task<CommandResult> Handle(DeleteAccountCommand command)
    {
        var account = await _accountCommandRepository.GetGraphAsync(command.Id) ?? throw new InvalidEntityStateException(ErrorMessages.Get(ErrorMessageKey.NotAccount));

        _accountCommandRepository.Delete(account);
        await _accountCommandRepository.CommitAsync();

        return Ok();
    }
}
