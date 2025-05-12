using AccountManagement.Core.Contract.Accounts.Commands;
using AccountManagement.Core.Contract.Roles.Commands;
using AccountManagement.Core.RequestResponse.Accounts.Commands.Login;
using Framework.AuthHelper;
using Framework.Enums.Validation;
using Framework.PasswordHasher;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace AccountManagement.Core.ApplicationService.Accounts.Commands.Login;

public sealed class LoginAccountCommandHandler : CommandHandler<LoginAccountCommand, LoginAccountCommandResult>
{
    readonly IAccountCommandRepository _accountCommandommandRepository;
    readonly IPasswordHasher _passwordHasher;
    readonly IRoleCommandRepository _roleCommandRepository;
    readonly IAuthHelper _authHelper;


    public LoginAccountCommandHandler(ZaminServices zainServices,
        IAccountCommandRepository accountCommandommandRepository,
        IPasswordHasher passwordHasher,
        IRoleCommandRepository roleCommandRepository,
        IAuthHelper authHelper) : base(zainServices)
    {
        _accountCommandommandRepository = accountCommandommandRepository;
        _passwordHasher = passwordHasher;
        _roleCommandRepository = roleCommandRepository;
        _authHelper = authHelper;
    }

    public override async Task<CommandResult<LoginAccountCommandResult>> Handle(LoginAccountCommand command)
    {
        // null ha check shavad
        var account = await _accountCommandommandRepository.GetByUserName(command.UserName)
            ?? throw new InvalidEntityStateException(ErrorMessages.Get(ErrorMessageKey.UsernameAlreadyExists));

        if (!_passwordHasher.Check(account.Password, command.Password).Verified)
            throw new InvalidEntityStateException(ErrorMessages.Get(ErrorMessageKey.UsernameAlreadyExists));

        var authModel = new AuthViewModel(account.Id,
                                          account.FullName,
                                          account.Username);

        _authHelper.Signin(authModel);

        return Ok(new LoginAccountCommandResult(account.FullName, account.Username, account.Mobile));
    }
}
