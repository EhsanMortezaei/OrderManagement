using AccountManagement.Core.Contract.Permissions.Commands;
using AccountManagement.Core.RequestResponse.Permissions.Commands.Update;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace AccountManagement.Core.ApplicationService.Permissions.Commands.Update
{
    public class UpdatePermissionCommandHandler : CommandHandler<UpdatePermissionCommand>
    {
        private readonly IPermissionCommandRepository _permissionCommandRepository;

        public UpdatePermissionCommandHandler(ZaminServices zaminServices,
            IPermissionCommandRepository permissionCommandRepository) : base(zaminServices)
        {
            _permissionCommandRepository = permissionCommandRepository;
        }

        public override async Task<CommandResult> Handle(UpdatePermissionCommand command)
        {
            var permission = await _permissionCommandRepository.GetAsync(command.Id);

            permission.Edit(command.Code, command.Name);
            await _permissionCommandRepository.CommitAsync();
            return Ok();
        }
    }
}
