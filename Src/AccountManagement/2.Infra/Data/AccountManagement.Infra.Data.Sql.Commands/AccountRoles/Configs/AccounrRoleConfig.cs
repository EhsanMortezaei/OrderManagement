using AccountManagement.Core.Domain.AccountRoles.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccountManagement.Infra.Data.Sql.Commands.AccountRoles.Configs
{
    public class AccounrRoleConfig : IEntityTypeConfiguration<AccountRole>
    {
        public void Configure(EntityTypeBuilder<AccountRole> builder)
        {
        }
    }
}
