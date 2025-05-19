using AccountManagement.Core.Contract.Accounts.Commands;
using AccountManagement.Core.RequestResponse.Accounts.Commands.Delete;
using Framework.ErrorMessages;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace AccountManagement.Core.ApplicationService.Accounts.Commands.Delete;

public class DeleteAccountCommandHandler(ZaminServices zaminServices,
    IAccountCommandRepository accountCommandRepository) : CommandHandler<DeleteAccountCommand>(zaminServices)
{
    public override async Task<CommandResult> Handle(DeleteAccountCommand command)
    {
        var account = await accountCommandRepository.GetGraphAsync(command.Id)
            ?? throw new InvalidEntityStateException(ErrorMessage.NotAccount);

        accountCommandRepository.Delete(account);
        await accountCommandRepository.CommitAsync();

        return Ok();
    }
}
