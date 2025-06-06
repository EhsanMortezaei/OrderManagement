﻿using AccountManagement.Core.Contract.Accounts.Commands;
using AccountManagement.Core.RequestResponse.Accounts.Commands.Update;
using Framework.Enums.Validation;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace AccountManagement.Core.ApplicationService.Accounts.Commands.Update;

public sealed class UpdateAccountCommandHandler(ZaminServices zainServices,
    IAccountCommandRepository accountCommandRepository) : CommandHandler<UpdateAccountCommand>(zainServices)
{
    public override async Task<CommandResult> Handle(UpdateAccountCommand command)
    {
        var account = await accountCommandRepository.GetAsync(command.Id);
        if (account is null)
            throw new InvalidEntityStateException(ErrorMessages.Get(ErrorMessageKey.NotAccount));

        account.Edit(command.Fullname,
                     command.Username,
                     command.Mobile,
                     command.ProfilePhoto);
        await accountCommandRepository.CommitAsync();
        return Ok();
    }
}
