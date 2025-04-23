using ShopManagement.Core.Domain.Orders.Entities;
using Zamin.Core.Contracts.Data.Commands;

namespace ShopManagement.Core.Contracts.Orders.Commands
{
    public interface IOrderCommandRepository : ICommandRepository<Order, int>
    {
    }
}
