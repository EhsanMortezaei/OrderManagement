using AccountManagement.Core.Contract.Accounts.Queries;
using AccountManagement.Core.RequestResponse.Accounts.Queries.GetAccountById;
using AccountManagement.Infra.Data.Sql.Queries.Common;
using Microsoft.EntityFrameworkCore;
using Zamin.Infra.Data.Sql.Queries;


namespace AccountManagement.Infra.Data.Sql.Queries.Accounts;

public sealed class AccountQueryRepository(AccountManagementQueryDbContext dbContext) : BaseQueryRepository<AccountManagementQueryDbContext>(dbContext), IAccountQueryRepository
{
    public async Task<AccountQr?> ExecuteAsync(GetAccountByIdQuery query)
    => await _dbContext.Accounts.Select(c => new AccountQr()
    {
        Id = c.Id,
        Fullname = c.Fullname,
        Username = c.Username,
        Password = c.Password,
        Mobile = c.Mobile,
        ProfilePhoto = c.ProfilePhoto,

    }).FirstOrDefaultAsync(c => c.Id.Equals(query.AccountId));
}
