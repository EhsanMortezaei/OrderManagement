using AccountManagement.Core.Contract.Accounts.Queries;
using InventoryManagement.Core.Contracts.Inventories.Queries;
using InventoryManagement.Core.Contracts.InventoryOperations.Queries;
using InventoryManagement.Core.RequestResponse.Inventories.Queries;
using InventoryManagement.Core.RequestResponse.InventoryOperations.Queries;
using InventoryManagement.Infra.Data.Sql.Queries.Common;
using Microsoft.EntityFrameworkCore;
using Zamin.Core.Contracts.Data.Queries;
using Zamin.Infra.Data.Sql.Queries;

namespace InventoryManagement.Infra.Data.Sql.Queries.InventoryOperations
{
    public class InventoryOperationQueryRepository : BaseQueryRepository<InventoryManagementQueryDbContext>, IInventoryOperationsQueryRepository
    {
        public InventoryOperationQueryRepository(InventoryManagementQueryDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<InventoryOperationQr?> ExecuteAsync(GetInventoryOperationByIdQuery query)
        => await _dbContext.InventoryOperations.Select(c => new InventoryOperationQr()
        {
            Id = c.Id,
            Operation = c.Operation,
            Count = c.Count,
            OperatorId = c.OperatorId,
            OperationDate = c.OperationDate,
            CurrentCount = c.CurrentCount,
            Description = c.Description,
            OrderId = c.OrderId,
            InventoryId = c.InventoryId,

        }).FirstOrDefaultAsync(c => c.Id.Equals(query.InventoryOperationId));
    }
}
