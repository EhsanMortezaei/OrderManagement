using Framework.ErrorMessages;
using ShopManagement.Core.Contracts.Orders.Commands;
using ShopManagement.Core.RequestResponse.Orders.Command.Update;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace ShopManagement.Core.ApplicationService.Orders.Commands.Update;

public sealed class UpdateOrderCommandHandler(ZaminServices zaminServices,
    IOrderCommandRepository orderCommandRepository) : CommandHandler<UpdateOrderCommand>(zaminServices)
{
    public override async Task<CommandResult> Handle(UpdateOrderCommand command)
    {
        var order = await orderCommandRepository.GetAsync(command.Id)
            ?? throw new InvalidEntityStateException(ErrorMessage.OrderError);

        order.Edit(command.AccountId,
                   command.PaymentMethod,
                   command.TotalAmount,
                   command.DiscountAmount,
                   command.PayAmount);

        await orderCommandRepository.CommitAsync();
        return Ok();
    }
}
