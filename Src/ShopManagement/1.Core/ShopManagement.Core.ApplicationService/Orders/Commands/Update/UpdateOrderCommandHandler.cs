using Framework.Enums.Validation;
using ShopManagement.Core.Contracts.Orders.Commands;
using ShopManagement.Core.RequestResponse.Orders.Command.Update;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace ShopManagement.Core.ApplicationService.Orders.Commands.Update;

public sealed class UpdateOrderCommandHandler : CommandHandler<UpdateOrderCommand>
{
    readonly IOrderCommandRepository _orderCommandRepository;

    // pimrry constructor
    public UpdateOrderCommandHandler(ZaminServices zaminServices,
        IOrderCommandRepository orderCommandRepository) : base(zaminServices)
    {
        _orderCommandRepository = orderCommandRepository;
    }

    public override async Task<CommandResult> Handle(UpdateOrderCommand command)
    {
        var order = await _orderCommandRepository.GetAsync(command.Id);
        // eslah shavad
        if (order is null)
            throw new InvalidEntityStateException(ErrorMessages.Get(ErrorMessageKey.OrderError));

        order.Edit(command.AccountId,
                   command.PaymentMethod,
                   command.TotalAmount,
                   command.DiscountAmount,
                   command.PayAmount);

        await _orderCommandRepository.CommitAsync();
        return Ok();
    }
}
