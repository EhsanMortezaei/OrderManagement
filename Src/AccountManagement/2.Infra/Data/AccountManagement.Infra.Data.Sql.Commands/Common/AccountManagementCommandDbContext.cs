using AccountManagement.Core.Domain.Accounts.Entities;
using AccountManagement.Core.Domain.Roles.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Zamin.Extensions.Events.Outbox.Dal.EF;

namespace AccountManagement.Infra.Data.Sql.Commands.Common;

public sealed class AccountManagementCommandDbContext(
    DbContextOptions<AccountManagementCommandDbContext> options) : BaseOutboxCommandDbContext(options)
{
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<AccountRole> AccountRoles { get; set; }
    public DbSet<Permission> Permissions { get; set; }
    public DbSet<AccountRole> RolesRoles { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
