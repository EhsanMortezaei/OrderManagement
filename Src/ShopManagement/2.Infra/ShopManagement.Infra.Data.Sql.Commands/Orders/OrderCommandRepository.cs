using ShopManagement.Core.Contracts.Orders.Commands;
using ShopManagement.Core.Domain.Orders.Entities;
using ShopManagement.Infra.Data.Sql.Commands.Common;
using Zamin.Infra.Data.Sql.Commands;

namespace ShopManagement.Infra.Data.Sql.Commands.Orders;

public sealed class OrderCommandRepository :
    BaseCommandRepository<Order, ShopManagementCommandDbContext, int>,
    IOrderCommandRepository
{
    public OrderCommandRepository(ShopManagementCommandDbContext dbContext) : base(dbContext)
    {
    }
}
