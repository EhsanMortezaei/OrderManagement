using AccountManagement.Core.Contract.Permissions.Queries;
using AccountManagement.Core.RequestResponse.Accounts.Queries;
using AccountManagement.Core.RequestResponse.Permissions.Queries;
using AccountManagement.Infra.Data.Sql.Queries.Common;
using Microsoft.EntityFrameworkCore;
using Zamin.Infra.Data.Sql.Queries;

namespace AccountManagement.Infra.Data.Sql.Queries.Permissions
{
    public class PermissionQueryRepository : BaseQueryRepository<AccountManagementQueryDbContext>, IPermissionQueryRepository
    {
        public PermissionQueryRepository(AccountManagementQueryDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<PermissionQr?> ExecuteAsync(GetPermissionByIdQuery query)
        => await _dbContext.Permissions.Select(c => new PermissionQr()
        {
            Id = c.Id,
            Code = c.Code,
            Name = c.Name,
            AccountId = c.AccountId,
            RoleId = c.RoleId,
        }).FirstOrDefaultAsync(c => c.Id.Equals(query.PermissionId));
    }
}
