using Zamin.Core.Domain.Events;

namespace AccountManagement.Core.Domain.Accounts.Events;

public sealed record AccountCreated(Guid BusinessId, string fullname,
                            string username,
                            string password,
                            string mobile,
                            string profilePhoto) : IDomainEvent
{
}
