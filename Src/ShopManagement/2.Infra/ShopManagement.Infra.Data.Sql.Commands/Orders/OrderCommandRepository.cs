using ShopManagement.Core.Contracts.Orders.Commands;
using ShopManagement.Core.Domain.Orders.Entities;
using ShopManagement.Infra.Data.Sql.Commands.Common;
using Zamin.Infra.Data.Sql.Commands;

namespace ShopManagement.Infra.Data.Sql.Commands.Orders;

public sealed class OrderCommandRepository(ShopManagementCommandDbContext dbContext) :
    BaseCommandRepository<Order, ShopManagementCommandDbContext, int>(dbContext),
    IOrderCommandRepository
{
}
