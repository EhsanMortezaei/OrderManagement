using AccountManagement.Core.Contract.Roles.Commands;
using AccountManagement.Core.RequestResponse.Roles.Commands.Update;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace AccountManagement.Core.ApplicationService.Roles.Commands.Update
{
    public class UpdateRoleCommandHandler : CommandHandler<UpdateRoleCommand>
    {
        private readonly IRoleCommandRepository _roleCommandRepository;

        public UpdateRoleCommandHandler(ZaminServices zaminServices,
            IRoleCommandRepository roleCommandRepository) : base(zaminServices)
        {
            _roleCommandRepository = roleCommandRepository;
        }

        public override async Task<CommandResult> Handle(UpdateRoleCommand command)
        {
            var role = await _roleCommandRepository.GetAsync(command.Id);
            if (role is null)
                throw new InvalidEntityStateException("کاربر یافت نشد");

            role.Edite(command.Name, command.Permissions);
            await _roleCommandRepository.CommitAsync();
            return Ok();
        }
    }
}
