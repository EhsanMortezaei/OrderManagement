using InventoryManagement.Core.Contracts.Inventories.Commands;
using InventoryManagement.Core.RequestResponse.Inventories.Commands.Update;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace InventoryManagement.Core.ApplicationService.Inventories.Commands.Update
{
    public class UpdateInventoryCommandHandler : CommandHandler<UpdateInventoryCommand>
    {
        private readonly IInventoryCommandRepository _inventoryCommandRepository;
        public UpdateInventoryCommandHandler(ZaminServices zaminServices,
            IInventoryCommandRepository inventoryCommandRepository) : base(zaminServices)
        {
            _inventoryCommandRepository = inventoryCommandRepository;
        }

        public override async Task<CommandResult> Handle(UpdateInventoryCommand command)
        {
            var inventory = await _inventoryCommandRepository.GetAsync(command.Id);
            if (inventory is null)
                throw new InvalidEntityStateException("در انبار یافت نشد");

            inventory.Edit(command.ProductId, command.UnitPrice, command.Operations);
            await _inventoryCommandRepository.CommitAsync();
            return Ok();
        }
    }
}
