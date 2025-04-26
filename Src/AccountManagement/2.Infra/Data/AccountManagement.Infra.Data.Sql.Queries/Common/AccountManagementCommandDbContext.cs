using AccountManagement.Core.Domain.Accounts.Entities;
using AccountManagement.Core.Domain.Roles.Entities;
using Microsoft.EntityFrameworkCore;
using Zamin.Extensions.Events.Outbox.Dal.EF;

namespace AccountManagement.Infra.Data.Sql.Queries.Common
{
    public class AccountManagementCommandDbContext : BaseOutboxCommandDbContext
    {
        DbSet<Account> Accounts { get; set; }
        DbSet<Role> Roles { get; set; }
        DbSet<Permission> Permissions { get; set; }

        public AccountManagementCommandDbContext(
            DbContextOptions<AccountManagementCommandDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
