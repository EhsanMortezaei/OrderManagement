using InventoryManagement.Core.Domain.Inventories.Entities;
using Zamin.Core.Contracts.Data.Commands;

namespace InventoryManagement.Core.Contracts.Inventories.Commands
{
    public interface IInventoryCommandRepository : ICommandRepository<Inventory, int>
    {
    }
}
