using AccountManagement.Core.Contract.Accounts.Commands;
using AccountManagement.Core.RequestResponse.Accounts.Commands.Delete;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Contracts.Data.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace AccountManagement.Core.ApplicationService.Accounts.Commands.Delete;

public class DeleteAccountCommandHandler(ZaminServices zaminServices,
    IAccountCommandRepository accountCommandRepository,
    IUnitOfWork accountUnitOfWork) : CommandHandler<DeleteAccountCommand>(zaminServices)
{
     readonly IAccountCommandRepository _accountCommandRepository = accountCommandRepository;
     readonly IUnitOfWork _accountUnitOfWork = accountUnitOfWork;

    public override async Task<CommandResult> Handle(DeleteAccountCommand command)
    {
        var account = await _accountCommandRepository.GetGraphAsync(command.Id) ?? throw new InvalidEntityStateException("حساب یافت نشد");

        _accountCommandRepository.Delete(account);
        await _accountCommandRepository.CommitAsync();

        return Ok();
    }
}
