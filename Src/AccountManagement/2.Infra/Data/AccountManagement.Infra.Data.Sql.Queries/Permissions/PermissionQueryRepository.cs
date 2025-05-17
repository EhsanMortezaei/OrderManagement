using AccountManagement.Core.Contract.Permissions.Queries;
using AccountManagement.Core.RequestResponse.Permissions.Queries;
using AccountManagement.Infra.Data.Sql.Queries.Common;
using Microsoft.EntityFrameworkCore;
using Zamin.Infra.Data.Sql.Queries;

namespace AccountManagement.Infra.Data.Sql.Queries.Permissions;

public class PermissionQueryRepository(AccountManagementQueryDbContext dbContext) : BaseQueryRepository<AccountManagementQueryDbContext>(dbContext), IPermissionQueryRepository
{
    public async Task<PermissionQr?> ExecuteAsync(GetPermissionByIdQuery query)
    => await _dbContext.Permissions.Select(c => new PermissionQr()
    {
        Id = c.Id,
        Code = c.Code,
        Name = c.Name,
        RoleId = c.RoleId,
    }).FirstOrDefaultAsync(c => c.Id.Equals(query.PermissionId));
}
