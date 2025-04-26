using ShopManagement.Core.Contracts.Orders.Commands;
using ShopManagement.Core.RequestResponse.Orders.Command.Update;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace ShopManagement.Core.ApplicationService.Orders.Commands.Update
{
    public class UpdateOrderCommandHandler : CommandHandler<UpdateOrderCommand>
    {
        private readonly IOrderCommandRepository _orderCommandRepository;

        public UpdateOrderCommandHandler(ZaminServices zaminServices,
            IOrderCommandRepository orderCommandRepository) : base(zaminServices)
        {
            _orderCommandRepository = orderCommandRepository;
        }

        public override async Task<CommandResult> Handle(UpdateOrderCommand command)
        {
            var order = await _orderCommandRepository.GetAsync(command.Id);
            if (order is null)
                throw new InvalidEntityStateException("سفارش یافت نشد");

            order.Edit(command.AccountId, command.PaymentMethod,
                command.TotalAmount, command.DiscountAmount,
                command.PayAmount);

            await _orderCommandRepository.CommitAsync();
            return Ok();
        }
    }
}
