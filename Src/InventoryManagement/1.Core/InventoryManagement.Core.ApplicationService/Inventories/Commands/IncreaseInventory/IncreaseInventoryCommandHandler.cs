using _0_Framework.Application;
using InventoryManagement.Core.Contracts.Inventories.Commands;
using InventoryManagement.Core.RequestResponse.Inventories.Commands.Create;
using InventoryManagement.Core.RequestResponse.Inventories.Commands.IncreaseInventory;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace InventoryManagement.Core.ApplicationService.Inventories.Commands.IncreaseInventory
{
    public class IncreaseInventoryCommandHandler : CommandHandler<IncreaseInventoryCommand, Guid>
    {
        private IInventoryCommandRepository _inventoryCommandRepository;
        private readonly IAuthHelper _authHelper;

        public IncreaseInventoryCommandHandler(ZaminServices zaminServices,
            IAuthHelper authHelper, IInventoryCommandRepository inventoryCommandRepository) : base(zaminServices)
        {
            _authHelper = authHelper;
            _inventoryCommandRepository = inventoryCommandRepository;
        }

        public override async Task<CommandResult<Guid>> Handle(IncreaseInventoryCommand command)
        {
            var inventory = await _inventoryCommandRepository.GetAsync(command.InventoryId);

            const long operatorId = 1;
            inventory.Increase(command.Count, operatorId, command.Description);
            await _inventoryCommandRepository.CommitAsync();

            return Ok(inventory.BusinessId.Value);
        }
    }
}
