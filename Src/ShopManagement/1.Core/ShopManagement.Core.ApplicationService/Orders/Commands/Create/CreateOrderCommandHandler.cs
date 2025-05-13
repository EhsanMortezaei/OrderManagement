using ShopManagement.Core.Contracts.Orders.Commands;
using ShopManagement.Core.Domain.Orders.Entities;
using ShopManagement.Core.RequestResponse.Orders.Command.Create;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace ShopManagement.Core.ApplicationService.Orders.Commands.Create;

public sealed class CreateOrderCommandHandler(ZaminServices zaminServices,
    IOrderCommandRepository orderCommandRepository) : CommandHandler<CreateOrderCommand, Guid>(zaminServices)
{
    public override async Task<CommandResult<Guid>> Handle(CreateOrderCommand command)
    {
        var order = new Order(command.AccountId,
                              command.PaymentMethod,
                              command.TotalAmount,
                              command.DiscountAmount,
                              command.PayAmount,
                              command.IssueTrackingNo,
                              command.Items);

        await orderCommandRepository.InsertAsync(order);
        await orderCommandRepository.CommitAsync();

        return Ok(order.BusinessId.Value);
    }
}
