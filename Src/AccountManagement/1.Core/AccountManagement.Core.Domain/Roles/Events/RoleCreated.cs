using AccountManagement.Core.Domain.Accounts.Entities;
using AccountManagement.Core.Domain.Permissions.Entities;
using Zamin.Core.Domain.Events;

namespace AccountManagement.Core.Domain.Roles.Events
{
    public class RoleCreated(Guid BusinessId,
                             string name,
                             List<Permission> permissions) : IDomainEvent
    {
    }
}
