using InventoryManagement.Core.Contracts.InventoryOperations.Commands;
using InventoryManagement.Core.Domain.Inventories.Entities;
using InventoryManagement.Core.RequestResponse.InventoryOperations.Commands.Update;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace InventoryManagement.Core.ApplicationService.InventoryOperations.Commands.Update
{
    public class UpdateInventoryOperationCommandHandler : CommandHandler<UpdateInventoryOperationCommand>
    {
        private readonly IInventoryOperationCommandRepository _inventoryOperationCommandRepository;

        public UpdateInventoryOperationCommandHandler(ZaminServices zainServices,
            IInventoryOperationCommandRepository inventoryOperationCommandRepository) : base(zainServices)
        {
            _inventoryOperationCommandRepository = inventoryOperationCommandRepository;
        }

        public override async Task<CommandResult> Handle(UpdateInventoryOperationCommand command)
        {
            var inventoryOperation = await _inventoryOperationCommandRepository.GetAsync(command.Id);
            if (inventoryOperation is null)
                throw new InvalidEntityStateException("یافت نشد");

            inventoryOperation.Edit(command.Operation,
                                    command.Count,
                                    command.OperatorId,
                                    command.CurrentCount,
                                    command.Description,
                                    command.OrderId,
                                    command.InventoryId);
            await _inventoryOperationCommandRepository.CommitAsync();
            return Ok();

        }
    }
}
