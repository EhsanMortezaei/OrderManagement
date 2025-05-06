using AccountManagement.Core.Domain.Accounts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccountManagement.Infra.Data.Sql.Commands.Accounts.Configs
{
    public class AccountConfig : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Fullname).HasMaxLength(50).IsUnicode().IsRequired();
            builder.Property(x => x.Username).HasMaxLength(50).IsRequired();
            builder.Property(x => x.ProfilePhoto).HasMaxLength(100);
            builder.Property(x => x.Password).IsRequired();
            builder.Property(x => x.Mobile).HasMaxLength(20).IsRequired();
        }
    }
}
