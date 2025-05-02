using AccountManagement.Core.Domain.Permissions.Entities;
using Zamin.Core.Domain.Entities;

namespace AccountManagement.Core.Domain.AccountRoles.Entities
{
    public class AccountRole : AggregateRoot<int>
    {
        public int AccountId { get; private set; }
        public int RoleId { get; private set; }
        public List<Permission> Permissions { get; private set; }

        protected AccountRole() { }

        public AccountRole(int accountId, int roleId)
        {
            AccountId = accountId;
            RoleId = roleId;
        }

        public static AccountRole Create(int accountId, int roleId) => new AccountRole(accountId, roleId);
    }
}
