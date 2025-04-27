using _0_Framework.Application;
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
        private readonly IAuthHelper _authHelper;


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

        public override async Task<CommandResult<Guid>> Handle(LoginAccountCommand command)
        {
            var account = await _accountCommandommandRepository.GetAsync(command.UserName);
            if (account == null)
            {
                throw new InvalidEntityStateException("نام کربری یا کلمه رمز اشتباه است");
            }

            var result = _passwordHasher.Check(account.Password, command.Password);
            if (!result.Verified)
            {
                throw new InvalidEntityStateException("نام کربری یا کلمه رمز اشتباه است");
            }

            var permissins = _roleCommandRepository.Get(account.RoleId)
                .Permissions
                .Select(x => x.Code)
                .ToList();

            var authModel = new AuthViewModel(account.Id,
                                              account.RoleId,
                                              account.Fullname,
                                              account.Username,
                                              permissins);

            _authHelper.Signin(authModel);

            return Ok(account.BusinessId.Value);
        }
    }
}
