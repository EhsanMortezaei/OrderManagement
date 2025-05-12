using AccountManagement.Core.Contract.Roles.Commands;
using AccountManagement.Core.Domain.Roles.Entities;
using AccountManagement.Infra.Data.Sql.Commands.Common;
using Zamin.Infra.Data.Sql.Commands;

namespace AccountManagement.Infra.Data.Sql.Commands.Roles;

public sealed class RoleCommandRepository :
    BaseCommandRepository<Role, AccountManagementCommandDbContext, int>,
    IRoleCommandRepository
{
    public RoleCommandRepository(AccountManagementCommandDbContext dbContext) : base(dbContext)
    {
    }
}
