using Zamin.Core.Domain.Events;

namespace AccountManagement.Core.Domain.Roles.Events;

// agar estefade nemishavad az event hazf shavad


// sealed record 
public sealed record RoleCreated(Guid BusinessId, string name) : IDomainEvent;