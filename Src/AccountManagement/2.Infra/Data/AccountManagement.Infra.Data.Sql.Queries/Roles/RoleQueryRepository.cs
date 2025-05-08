using AccountManagement.Core.Contract.Roles.Queries;
using AccountManagement.Core.RequestResponse.Roles.Queries;
using AccountManagement.Infra.Data.Sql.Queries.Common;
using Microsoft.EntityFrameworkCore;
using Zamin.Infra.Data.Sql.Queries;

namespace AccountManagement.Infra.Data.Sql.Queries.Roles;

public class RoleQueryRepository : BaseQueryRepository<AccountManagementQueryDbContext>, IRoleQueryRepository
{
    public RoleQueryRepository(AccountManagementQueryDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<RoleQr?> ExecuteAsync(GetRoleByIdQuery query)
    => await _dbContext.Roles.Select(c => new RoleQr()
    {
        Id = c.Id,
        Name = c.Name,
    }).FirstOrDefaultAsync(c => c.Id.Equals(query.RoleId));
}
