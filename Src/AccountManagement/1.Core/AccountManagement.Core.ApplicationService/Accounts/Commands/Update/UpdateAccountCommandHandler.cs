using AccountManagement.Core.Contract.Accounts.Commands;
using AccountManagement.Core.RequestResponse.Accounts.Commands.Update;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace AccountManagement.Core.ApplicationService.Accounts.Commands.Update;

public sealed class UpdateAccountCommandHandler : CommandHandler<UpdateAccountCommand>
{
     readonly IAccountCommandRepository _accountCommandRepository;

    public UpdateAccountCommandHandler(ZaminServices zainServices,
        IAccountCommandRepository accountCommandRepository) : base(zainServices)
    {
        _accountCommandRepository = accountCommandRepository;
    }

    public override async Task<CommandResult> Handle(UpdateAccountCommand command)
    {
        var account = await _accountCommandRepository.GetAsync(command.Id);
        if (account is null)
            throw new InvalidEntityStateException("کاربر یافت نشد");

        account.Edit(command.Fullname,
                     command.Username,
                     command.Mobile,
                     command.ProfilePhoto);
        await _accountCommandRepository.CommitAsync();
        return Ok();
    }
}
