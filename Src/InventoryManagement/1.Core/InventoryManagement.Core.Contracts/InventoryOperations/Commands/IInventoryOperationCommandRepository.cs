using InventoryManagement.Core.Domain.InventoryOperations.Entities;
using Zamin.Core.Contracts.Data.Commands;

namespace InventoryManagement.Core.Contracts.InventoryOperations.Commands
{
    public interface IInventoryOperationCommandRepository : ICommandRepository<InventoryOperation, int>
    {
    }
}
