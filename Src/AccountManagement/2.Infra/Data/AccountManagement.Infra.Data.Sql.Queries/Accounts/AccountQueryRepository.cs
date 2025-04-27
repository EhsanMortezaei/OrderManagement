using AccountManagement.Core.Contract.Accounts.Queries;
using AccountManagement.Core.RequestResponse.Accounts.Queries;
using AccountManagement.Infra.Data.Sql.Queries.Common;
using Microsoft.EntityFrameworkCore;
using Zamin.Infra.Data.Sql.Queries;

namespace AccountManagement.Infra.Data.Sql.Queries.Accounts
{
    //public class AccountQueryRepository : BaseQueryDbContext<AccountManagementQueryDbContext>, IAccountQueryRepository
    //{
    //    public AccountQueryRepository(AccountManagementQueryDbContext dbContext) : base(dbContext)
    //    {
    //    }
    //    public async Task<AccountQr?> ExecuteAsync(GetAccountByIdQuery query)
    //    => await _dbContext.Accounts.Select(c => new AccountQr()
    //    {
    //        Id = c.Id,
    //        Title = c.Title,
    //        Description = c.Description
    //    }).FirstOrDefaultAsync(c => c.Id.Equals(query.AccountId));
    //}
}
