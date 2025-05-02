using AccountManagement.Core.Contract.AccountRoles.Commands;
using AccountManagement.Core.Domain.AccountRoles.Entities;
using AccountManagement.Infra.Data.Sql.Queries.Common;
using Zamin.Infra.Data.Sql.Commands;

namespace AccountManagement.Infra.Data.Sql.Commands.AccountRoles
{
    public class AccountRoleCommandRepository : BaseCommandRepository<AccountRole, AccountManagementCommandDbContext, int>,
        IAccountRoleCommandRepository
    {
        public AccountRoleCommandRepository(AccountManagementCommandDbContext dbContext) : base(dbContext)
        {
        }
    }
}
