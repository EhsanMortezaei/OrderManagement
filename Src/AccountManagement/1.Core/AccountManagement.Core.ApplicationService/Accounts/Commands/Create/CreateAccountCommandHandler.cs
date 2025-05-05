using AccountManagement.Core.Contract.Accounts.Commands;
using AccountManagement.Core.Domain.Accounts.Entities;
using AccountManagement.Core.RequestResponse.Accounts.Commands.Create;
using Framework.PasswordHasher;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace AccountManagement.Core.ApplicationService.Accounts.Commands.Create
{
    public class CreateAccountCommandHandler : CommandHandler<CreateAccountCommand, Guid>
    {
        private readonly IPasswordHasher _passwordHasher;
        private readonly IAccountCommandRepository _accountCommandRepository;

        public CreateAccountCommandHandler(ZaminServices zaminServices,
            IAccountCommandRepository accountCommandRepository,
            IPasswordHasher passwordHasher) : base(zaminServices)
        {
            _accountCommandRepository = accountCommandRepository;
            _passwordHasher = passwordHasher;
        }

        public override async Task<CommandResult<Guid>> Handle(CreateAccountCommand command)
        {
            var passwordHasher = _passwordHasher.Hash(command.Password);
            var account = new Account(command.Fullname,
                                      command.Username,
                                      passwordHasher,
                                      command.Mobile,
                                      command.ProfilePhoto);

            await _accountCommandRepository.InsertAsync(account);
            await _accountCommandRepository.CommitAsync();

            return Ok(account.BusinessId.Value);
        }
    }
}
