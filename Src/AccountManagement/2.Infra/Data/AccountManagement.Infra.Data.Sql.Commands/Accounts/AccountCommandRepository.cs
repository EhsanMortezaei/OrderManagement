using AccountManagement.Core.Contract.Accounts.Commands;
using AccountManagement.Core.Domain.Accounts.Entities;
using AccountManagement.Infra.Data.Sql.Commands.Common;
using Microsoft.EntityFrameworkCore;
using Zamin.Infra.Data.Sql.Commands;

namespace AccountManagement.Infra.Data.Sql.Commands.Accounts;

public sealed class AccountCommandRepository(AccountManagementCommandDbContext dbContext, AccountManagementCommandDbContext context) :
    BaseCommandRepository<Account, AccountManagementCommandDbContext, int>(dbContext),
    IAccountCommandRepository
{
    public async Task<Account?> GetByUserName(string username)
    {
        return await context.Accounts.FirstOrDefaultAsync(x => x.Username == username);
    }
}
