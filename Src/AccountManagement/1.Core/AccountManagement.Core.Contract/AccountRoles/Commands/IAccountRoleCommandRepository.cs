using AccountManagement.Core.Domain.AccountRoles.Entities;
using Zamin.Core.Contracts.Data.Commands;

namespace AccountManagement.Core.Contract.AccountRoles.Commands
{
    public interface IAccountRoleCommandRepository : ICommandRepository<AccountRole, int>
    {
    }
}
