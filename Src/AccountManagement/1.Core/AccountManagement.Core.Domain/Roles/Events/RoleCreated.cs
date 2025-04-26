using AccountManagement.Core.Domain.Accounts.Entities;
using AccountManagement.Core.Domain.Roles.Entities;
using Zamin.Core.Domain.Events;

namespace AccountManagement.Core.Domain.Roles.Events
{
    public class RoleCreated(Guid BusinessId,
                             string name,
                             List<Permission> permissions,
                             List<Account> accounts) : IDomainEvent
    {
    }
}
