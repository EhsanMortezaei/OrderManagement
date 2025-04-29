using Zamin.Core.Domain.Events;

namespace AccountManagement.Core.Domain.Permissions.Event
{
    public class PermissionCreated(Guid BusinessId,
                                   int code,
                                   string name) : IDomainEvent
    {
    }
}
