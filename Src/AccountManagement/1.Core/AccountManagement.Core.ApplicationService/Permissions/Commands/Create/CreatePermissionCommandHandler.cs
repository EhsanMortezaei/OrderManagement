using AccountManagement.Core.Contract.Permissions.Commands;
using AccountManagement.Core.Domain.Permissions.Entities;
using AccountManagement.Core.RequestResponse.Permissions.Commands.Create;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace AccountManagement.Core.ApplicationService.Permissions.Commands.Create
{
    public class CreatePermissionCommandHandler : CommandHandler<CreatePermissionCommand, Guid>
    {
        private readonly IPermissionCommandRepository _permissionCommandRepository;

        public CreatePermissionCommandHandler(ZaminServices zaminServices,
            IPermissionCommandRepository permissionCommandRepository) : base(zaminServices)
        {
            _permissionCommandRepository = permissionCommandRepository;
        }

        public override async Task<CommandResult<Guid>> Handle(CreatePermissionCommand command)
        {
            var permission = new Permission(command.Code, command.Name);

            await _permissionCommandRepository.InsertAsync(permission);
            await _permissionCommandRepository.CommitAsync();

            return Ok(permission.BusinessId.Value);
        }
    }
}
