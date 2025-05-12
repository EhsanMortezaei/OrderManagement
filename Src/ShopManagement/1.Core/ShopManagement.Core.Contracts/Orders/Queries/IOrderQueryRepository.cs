using ShopManagement.Core.RequestResponse.Orders.Queries;

namespace ShopManagement.Core.Contracts.Orders.Queries;

public interface IOrderQueryRepository
{
    public Task<OrderQr?> ExecuteAsync(GetOrderByIdQuery query);
}
