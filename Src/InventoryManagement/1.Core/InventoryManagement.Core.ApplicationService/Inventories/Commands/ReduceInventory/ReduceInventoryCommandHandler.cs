using Framework.AuthHelper;
using InventoryManagement.Core.Contracts.Inventories.Commands;
using InventoryManagement.Core.RequestResponse.Inventories.Commands.ReduceInventory;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace InventoryManagement.Core.ApplicationService.Inventories.Commands.ReduceInventory
{
    public class ReduceInventoryCommandHandler : CommandHandler<ReduceInventoryCommand, Guid>
    {
        private readonly IInventoryCommandRepository _inventoryCommandRepository;
        private readonly IAuthHelper _authHelper;

        public ReduceInventoryCommandHandler(ZaminServices zaminServices,
            IInventoryCommandRepository inventoryCommandRepository, IAuthHelper authHelper) : base(zaminServices)
        {
            _inventoryCommandRepository = inventoryCommandRepository;
            _authHelper = authHelper;
        }

        public override async Task<CommandResult<Guid>> Handle(ReduceInventoryCommand command)
        {
            var inventory = await _inventoryCommandRepository.GetGraphAsync(command.InventoryId);

            var operatorId = _authHelper.CurrentAccountId();
            inventory.Reduce(command.Count, operatorId, command.Description, 0);
            _inventoryCommandRepository.Commit();
            return Ok(inventory.BusinessId.Value);
        }
    }
}
