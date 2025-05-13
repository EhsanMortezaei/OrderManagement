using AccountManagement.Core.Contract.Accounts.Commands;
using AccountManagement.Core.Domain.Accounts.Entities;
using AccountManagement.Infra.Data.Sql.Commands.Common;
using Microsoft.EntityFrameworkCore;
using Zamin.Infra.Data.Sql.Commands;

namespace AccountManagement.Infra.Data.Sql.Commands.Accounts;

public sealed class AccountCommandRepository :
    BaseCommandRepository<Account, AccountManagementCommandDbContext, int>,
    IAccountCommandRepository
{
    readonly AccountManagementCommandDbContext _context;
    public AccountCommandRepository(AccountManagementCommandDbContext dbContext, AccountManagementCommandDbContext context) : base(dbContext)
    {
        _context = context;
    }

    public async Task<Account?> GetByUserName(string username)
    {
        return await _context.Accounts.FirstOrDefaultAsync(x => x.Username == username);
    }
}
