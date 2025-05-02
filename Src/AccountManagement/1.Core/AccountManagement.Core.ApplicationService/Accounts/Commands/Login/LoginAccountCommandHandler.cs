using _0_Framework.Application;
using AccountManagement.Core.Contract.AccountRoles.Commands;
using AccountManagement.Core.Contract.Accounts.Commands;
using AccountManagement.Core.Contract.Roles.Commands;
using AccountManagement.Core.RequestResponse.Accounts.Commands.Login;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace AccountManagement.Core.ApplicationService.Accounts.Commands.Login
{
    public class LoginAccountCommandHandler : CommandHandler<LoginAccountCommand, Guid>
    {
        private readonly IAccountCommandRepository _accountCommandommandRepository;
        private readonly IPasswordHasher _passwordHasher;
        private readonly IRoleCommandRepository _roleCommandRepository;
        private readonly IAccountRoleCommandRepository _accountRoleCommandRepository;
        private readonly IAuthHelper _authHelper;


        public LoginAccountCommandHandler(ZaminServices zainServices,
            IAccountCommandRepository accountCommandommandRepository,
            IPasswordHasher passwordHasher,
            IRoleCommandRepository roleCommandRepository,
            IAuthHelper authHelper,
            IAccountRoleCommandRepository accountRoleCommandRepository) : base(zainServices)
        {
            _accountCommandommandRepository = accountCommandommandRepository;
            _passwordHasher = passwordHasher;
            _roleCommandRepository = roleCommandRepository;
            _authHelper = authHelper;
            _accountRoleCommandRepository = accountRoleCommandRepository;
        }

        public override async Task<CommandResult<Guid>> Handle(LoginAccountCommand command)
        {
            var account = await _accountCommandommandRepository.GetAsync(command.UserName);
            if (account == null)
            {
                throw new InvalidEntityStateException("نام کاربری یا کلمه رمز اشتباه است");
            }

            var result = _passwordHasher.Check(account.Password, command.Password);
            if (!result.Verified)
            {
                throw new InvalidEntityStateException("نام کاربری یا کلمه رمز اشتباه است");
            }

            var permissins = _accountRoleCommandRepository.Get(account.Username)
                .Permissions
                .Select(x => x.Code)
                .ToList();

            var authModel = new AuthViewModel(account.Id,
                                              account.Fullname,
                                              account.Username,
                                              permissins);

            _authHelper.Signin(authModel);

            return Ok(account.BusinessId.Value);
        }
    }
}
