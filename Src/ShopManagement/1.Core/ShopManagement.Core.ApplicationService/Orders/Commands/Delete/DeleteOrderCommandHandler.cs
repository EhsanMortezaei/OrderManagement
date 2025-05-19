using Framework.ErrorMessages;
using ShopManagement.Core.Contracts.Orders.Commands;
using ShopManagement.Core.RequestResponse.Orders.Command.Delete;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace ShopManagement.Core.ApplicationService.Orders.Commands.Delete;

public sealed class DeleteOrderCommandHandler(ZaminServices zaminServices,
    IOrderCommandRepository orderCommandRepository) : CommandHandler<DeleteOrderCommand>(zaminServices)
{
    public override async Task<CommandResult> Handle(DeleteOrderCommand command)
    {
        var order = await orderCommandRepository.GetGraphAsync(command.Id)
            ?? throw new InvalidEntityStateException(ErrorMessage.InventoyError);

        orderCommandRepository.Delete(order);
        await orderCommandRepository.CommitAsync();

        return Ok();
    }
}
