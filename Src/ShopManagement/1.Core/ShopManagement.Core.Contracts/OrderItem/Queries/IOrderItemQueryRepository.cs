using ShopManagement.Core.RequestResponse.OrderItems.Queries;

namespace ShopManagement.Core.Contracts.OrderItem.Queries
{
    public interface IOrderItemQueryRepository
    {
        public Task<OrderItemQr?> ExecuteAsync(GetOrderItemByIdQuery query);
    }
}
