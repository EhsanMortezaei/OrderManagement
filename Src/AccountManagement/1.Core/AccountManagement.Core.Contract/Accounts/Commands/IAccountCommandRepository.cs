using AccountManagement.Core.Domain.Accounts.Entities;
using Zamin.Core.Contracts.Data.Commands;

namespace AccountManagement.Core.Contract.Accounts.Commands
{
    public interface IAccountCommandRepository : ICommandRepository<Account, int>
    {
    }
}
