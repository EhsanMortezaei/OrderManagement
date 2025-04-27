using AccountManagement.Core.Contract.Accounts.Commands;
using AccountManagement.Core.Domain.Accounts.Entities;
using AccountManagement.Infra.Data.Sql.Queries.Common;
using Zamin.Infra.Data.Sql.Commands;

namespace AccountManagement.Infra.Data.Sql.Queries.Accounts
{
    public class AccountCommandRepository :
        BaseCommandRepository<Account, AccountManagementCommandDbContext, int>,
        IAccountCommandRepository
    {
        public AccountCommandRepository(AccountManagementCommandDbContext dbContext) : base(dbContext)
        {

        }
    }
}
