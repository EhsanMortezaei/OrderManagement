using AccountManagement.Core.Domain.Permissions.Entities;
using Zamin.Core.Contracts.Data.Commands;

namespace AccountManagement.Core.Contract.Permissions.Commands
{
    public interface IPermissionCommandRepository : ICommandRepository<Permission, int>
    {
    }
}
