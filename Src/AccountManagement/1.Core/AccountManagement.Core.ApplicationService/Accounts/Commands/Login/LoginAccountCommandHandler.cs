using AccountManagement.Core.Contract.Accounts.Commands;
using AccountManagement.Core.RequestResponse.Accounts.Commands.Login;
using Framework.AuthHelper;
using Framework.Enums.Validation;
using Framework.PasswordHasher;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace AccountManagement.Core.ApplicationService.Accounts.Commands.Login;

public sealed class LoginAccountCommandHandler(ZaminServices zainServices,
    IAccountCommandRepository accountCommandommandRepository,
    IPasswordHasher passwordHasher,
    IAuthHelper authHelper) : CommandHandler<LoginAccountCommand, LoginAccountCommandResult>(zainServices)
{
    public override async Task<CommandResult<LoginAccountCommandResult>> Handle(LoginAccountCommand command)
    {
        // null ha check shavad
        var account = await accountCommandommandRepository.GetByUserName(command.UserName)
            ?? throw new InvalidEntityStateException(ErrorMessages.Get(ErrorMessageKey.UsernameAlreadyExists));

        if (!passwordHasher.Check(account.Password, command.Password).Verified)
            throw new InvalidEntityStateException(ErrorMessages.Get(ErrorMessageKey.UsernameAlreadyExists));

        var authModel = new AuthViewModel(account.Id,
                                          account.FullName,
                                          account.Username);

        authHelper.Signin(authModel);

        return Ok(new LoginAccountCommandResult(account.FullName, account.Username, account.Mobile));
    }
}
