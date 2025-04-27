using InventoryManagement.Core.Contracts.InventoryOperations.Commands;
using InventoryManagement.Core.Domain.InventoryOperations.Entities;
using InventoryManagement.Core.RequestResponse.InventoryOperations.Commands.Create;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace InventoryManagement.Core.ApplicationService.InventoryOperations.Commands.Create
{
    public class CreateInventoryOperationCommandHandler : CommandHandler<CreateInventoryOperationCommand, Guid>
    {
        private readonly IInventoryOperationCommandRepository _inventoryOperationCommandRepository;

        public CreateInventoryOperationCommandHandler(ZaminServices zaminServices,
            IInventoryOperationCommandRepository inventoryOperationCommandRepository) : base(zaminServices)
        {
            _inventoryOperationCommandRepository = inventoryOperationCommandRepository;
        }

        public override async Task<CommandResult<Guid>> Handle(CreateInventoryOperationCommand command)
        {
            var inventoryOperation = new InventoryOperation(command.Operation,
                                                            command.Count,
                                                            command.OperatorId,
                                                            command.CurrentCount,
                                                            command.Description,
                                                            command.OrderId,
                                                            command.InventoryId);

            await _inventoryOperationCommandRepository.InsertAsync(inventoryOperation);
            await _inventoryOperationCommandRepository.CommitAsync();

            return Ok(inventoryOperation.BusinessId.Value);
        }
    }
}
