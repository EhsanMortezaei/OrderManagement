using AccountManagement.Core.Contract.Permissions.Commands;
using AccountManagement.Core.Domain.Permissions.Entities;
using AccountManagement.Infra.Data.Sql.Queries.Common;
using Microsoft.EntityFrameworkCore;
using Zamin.Infra.Data.Sql.Commands;

namespace AccountManagement.Infra.Data.Sql.Commands.Permissions
{
    public class PermissionCommandRepository :
        BaseCommandRepository<Permission, AccountManagementCommandDbContext, int>,
        IPermissionCommandRepository
    {
        public PermissionCommandRepository(AccountManagementCommandDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Permission>> GetByRoleIds(List<int> roleIds)
            => await _dbContext.Permissions.Where(x => roleIds.Contains(x.RoleId)).ToListAsync();
    }
}
