using AccountManagement.Core.Contract.Roles.Commands;
using AccountManagement.Core.RequestResponse.Roles.Commands.Delete;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Contracts.Data.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace AccountManagement.Core.ApplicationService.Roles.Commands.Delete;

public sealed class DeleteRoleCommandHandler(ZaminServices zaminServices,
    IRoleCommandRepository roleCommandRepository,
    IUnitOfWork roleUnitOfWork) : CommandHandler<DeleteRoleCommand>(zaminServices)
{
     readonly IRoleCommandRepository _roleCommandRepository = roleCommandRepository;
     readonly IUnitOfWork _roleUnitOfWork = roleUnitOfWork;
    public override async Task<CommandResult> Handle(DeleteRoleCommand command)
    {
        var role = await _roleCommandRepository.GetGraphAsync(command.Id) ?? throw new InvalidEntityStateException("حساب یافت نشد");

        _roleCommandRepository.Delete(role);
        await _roleCommandRepository.CommitAsync();

        return Ok();
    }
}
