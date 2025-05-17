using InventoryManagement.Core.Contracts.Inventories.Queries;
using InventoryManagement.Core.RequestResponse.Inventories.Queries;
using InventoryManagement.Infra.Data.Sql.Queries.Common;
using Microsoft.EntityFrameworkCore;
using Zamin.Infra.Data.Sql.Queries;

namespace InventoryManagement.Infra.Data.Sql.Queries.Inventories;

public sealed class InventoryQueryRepository(InventoryManagementQueryDbContext dbContext) : BaseQueryRepository<InventoryManagementQueryDbContext>(dbContext), IInventoryQueryRepository
{
    public async Task<InventoryQr?> ExecuteAsync(GetInventoryByIdQuery query)
    => await _dbContext.Inventories.Select(c => new InventoryQr()
    {
        Id = c.Id,
        ProductId = c.ProductId,
        UnitPrice = c.UnitPrice,
        InStock = c.InStock,

    }).FirstOrDefaultAsync(c => c.Id.Equals(query.InventoryId));
}
