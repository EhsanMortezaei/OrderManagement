using ShopManagement.Core.Contracts.Orders.Commands;
using ShopManagement.Core.RequestResponse.Orders.Command.Delete;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Contracts.Data.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace ShopManagement.Core.ApplicationService.Orders.Commands.Delete
{
    public sealed class DeleteOrderCommandHandler(ZaminServices zaminServices,
        IOrderCommandRepository orderCommandRepository,
        IUnitOfWork orderUnitOfWork) : CommandHandler<DeleteOrderCommand>(zaminServices)
    {
        private readonly IUnitOfWork _orderUnitOfWork = orderUnitOfWork;
        private readonly IOrderCommandRepository _orderCommandRepository = orderCommandRepository;

        public override async Task<CommandResult> Handle(DeleteOrderCommand command)
        {
            var order = await _orderCommandRepository.GetGraphAsync(command.Id) ?? throw new InvalidEntityStateException("سفارش یافت نشد");

            _orderCommandRepository.Delete(order);
            await _orderCommandRepository.CommitAsync();

            return Ok();
        }
    }
}
