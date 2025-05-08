using AccountManagement.Core.Domain.AccountRoles.Entities;
using AccountManagement.Core.Domain.Accounts.Entities;
using AccountManagement.Core.Domain.Permissions.Entities;
using AccountManagement.Core.Domain.Roles.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Zamin.Extensions.Events.Outbox.Dal.EF;

namespace AccountManagement.Infra.Data.Sql.Commands.Common
{
    public class AccountManagementCommandDbContext : BaseOutboxCommandDbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<AccountRole> AccountRoles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<AccountRole> RolesRoles { get; set; }

        public AccountManagementCommandDbContext(
            DbContextOptions<AccountManagementCommandDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
