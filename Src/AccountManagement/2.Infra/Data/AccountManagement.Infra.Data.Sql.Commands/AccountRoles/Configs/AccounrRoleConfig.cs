using AccountManagement.Core.Domain.Accounts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccountManagement.Infra.Data.Sql.Commands.AccountRoles.Configs;

public sealed class AccounrRoleConfig : IEntityTypeConfiguration<AccountRole>
{
    public void Configure(EntityTypeBuilder<AccountRole> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.AccountId).IsRequired();
        builder.Property(x => x.RoleId).IsRequired();

    }
}
