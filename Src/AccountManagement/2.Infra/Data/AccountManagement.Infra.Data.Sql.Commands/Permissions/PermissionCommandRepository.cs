using AccountManagement.Core.Contract.Accounts.Commands;
using AccountManagement.Core.Contract.Permissions.Commands;
using AccountManagement.Core.Domain.Accounts.Entities;
using AccountManagement.Core.Domain.Permissions.Entities;
using AccountManagement.Infra.Data.Sql.Queries.Common;
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
    }
}
