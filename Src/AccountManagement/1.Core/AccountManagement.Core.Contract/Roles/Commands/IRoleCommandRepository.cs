using AccountManagement.Core.Domain.Roles.Entities;
using Zamin.Core.Contracts.Data.Commands;

namespace AccountManagement.Core.Contract.Roles.Commands;

public interface IRoleCommandRepository : ICommandRepository<Role, int>
{
}
