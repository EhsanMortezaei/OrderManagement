using Zamin.Core.Domain.Events;

namespace AccountManagement.Core.Domain.Accounts.Events
{
    public class AccountCreated(Guid BusinessId, string fullname,
                                string username,
                                string password,
                                string mobile,
                                long roleId,
                                string profilePhoto) : IDomainEvent
    {
    }
}
