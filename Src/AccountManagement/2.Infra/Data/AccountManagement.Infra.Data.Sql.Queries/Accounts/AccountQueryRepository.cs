using AccountManagement.Core.Contract.Accounts.Queries;
using AccountManagement.Core.RequestResponse.Accounts.Queries;
using AccountManagement.Infra.Data.Sql.Queries.Common;
using Microsoft.EntityFrameworkCore;
using Zamin.Core.Contracts.Data.Queries;
using Zamin.Infra.Data.Sql.Queries;


namespace AccountManagement.Infra.Data.Sql.Queries.Accounts
{
    public class AccountQueryRepository : BaseQueryRepository<AccountManagementQueryDbContext>, IAccountQueryRepository
    {
        public AccountQueryRepository(AccountManagementQueryDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<AccountQr?> ExecuteAsync(GetAccountByIdQuery query)
        => await _dbContext.Accounts.Select(c => new AccountQr()
        {
            Id = c.Id,
            Fullname = c.Fullname,
            Username = c.Username,
            Password = c.Password,
            Mobile = c.Mobile,
            RoleId = c.RoleId,
            ProfilePhoto = c.ProfilePhoto,

        }).FirstOrDefaultAsync(c => c.Id.Equals(query.AccountId));
    }
}
