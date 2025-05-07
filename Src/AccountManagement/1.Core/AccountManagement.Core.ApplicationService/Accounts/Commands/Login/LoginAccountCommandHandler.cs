using AccountManagement.Core.Contract.AccountRoles.Commands;
using AccountManagement.Core.Contract.Accounts.Commands;
using AccountManagement.Core.Contract.Permissions.Commands;
using AccountManagement.Core.Contract.Roles.Commands;
using AccountManagement.Core.RequestResponse.Accounts.Commands.Login;
using Framework.AuthHelper;
using Framework.PasswordHasher;
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
        private readonly IPermissionCommandRepository _permissionCommandRepository;


        public LoginAccountCommandHandler(ZaminServices zainServices,
            IAccountCommandRepository accountCommandommandRepository,
            IPasswordHasher passwordHasher,
            IRoleCommandRepository roleCommandRepository,
            IAuthHelper authHelper,
            IAccountRoleCommandRepository accountRoleCommandRepository,
            IPermissionCommandRepository permissionCommandRepository) : base(zainServices)
        {
            _accountCommandommandRepository = accountCommandommandRepository;
            _passwordHasher = passwordHasher;
            _roleCommandRepository = roleCommandRepository;
            _authHelper = authHelper;
            _accountRoleCommandRepository = accountRoleCommandRepository;
            _permissionCommandRepository = permissionCommandRepository;
        }

        public override async Task<CommandResult<Guid>> Handle(LoginAccountCommand command)
        {
            var account = _accountCommandommandRepository.GetBy(command.UserName);
            if (account == null)
            {
                throw new InvalidEntityStateException("نام کاربری یا کلمه رمز اشتباه است");
            }

            var result = _passwordHasher.Check(account.Password, command.Password);
            if (!result.Verified)
            {
                throw new InvalidEntityStateException("نام کاربری یا کلمه رمز اشتباه است");
            }

            var accountRoles = await _accountRoleCommandRepository.GetByAccountId(account.Id);
            var roleIds = accountRoles.Select(x => x.RoleId).ToList();


            var permissions = await _permissionCommandRepository.GetByRoleIds(roleIds);
            var permissionCodes = permissions.Select(x => x.Code).ToList();

            var authModel = new AuthViewModel(account.Id,
                                              account.Fullname,
                                              account.Username,
                                              permissionCodes);

            _authHelper.Signin(authModel);

            return Ok(account.BusinessId.Value);
        }
    }
}
