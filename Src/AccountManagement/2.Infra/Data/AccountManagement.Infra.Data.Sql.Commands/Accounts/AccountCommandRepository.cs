using AccountManagement.Core.Contract.Accounts.Commands;
using AccountManagement.Core.Domain.Accounts.Entities;
using AccountManagement.Infra.Data.Sql.Commands.Common;
using Zamin.Infra.Data.Sql.Commands;

namespace AccountManagement.Infra.Data.Sql.Commands.Accounts
{
    public class AccountCommandRepository :
        BaseCommandRepository<Account, AccountManagementCommandDbContext, int>,
        IAccountCommandRepository
    {
        private readonly AccountManagementCommandDbContext _context;
        public AccountCommandRepository(AccountManagementCommandDbContext dbContext, AccountManagementCommandDbContext context) : base(dbContext)
        {
            _context = context;
        }

        public Account GetBy(string username)
        {
            return _context.Accounts.FirstOrDefault(x => x.Username == username);
        }
    }
}
