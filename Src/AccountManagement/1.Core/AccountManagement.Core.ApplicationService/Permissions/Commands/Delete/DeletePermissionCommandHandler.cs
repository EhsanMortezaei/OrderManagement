using AccountManagement.Core.Contract.Permissions.Commands;
using AccountManagement.Core.RequestResponse.Permissions.Commands.Delete;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Contracts.Data.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace AccountManagement.Core.ApplicationService.Permissions.Commands.Delete
{
    public class DeletePermissionCommandHandler(ZaminServices zaminServices,
        IPermissionCommandRepository permissionCommandRepository,
        IUnitOfWork permissionUnitOfWork) : CommandHandler<DeletePermissionCommand>(zaminServices)
    {
        private readonly IPermissionCommandRepository _permissionCommandRepository = permissionCommandRepository;
        private readonly IUnitOfWork _permissionUnitOfWork = permissionUnitOfWork;

        public override async Task<CommandResult> Handle(DeletePermissionCommand command)
        {
            var permission = await _permissionCommandRepository.GetGraphAsync(command.Id) ?? throw new InvalidEntityStateException("اجازه دسترسی یافت نشد");
            _permissionCommandRepository.Delete(permission);
            await _permissionUnitOfWork.CommitAsync();

            return Ok();

        }
    }
}
