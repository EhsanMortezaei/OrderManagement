using Zamin.Core.Domain.Entities;

namespace AccountManagement.Core.Domain.Accounts.Entities;

public sealed class AccountRole : Entity<int>
{
    public int AccountId { get;  set; }
    public int RoleId { get;  set; }

     AccountRole() { }

    public AccountRole(int roleId)
    {
        RoleId = roleId;
    }

    public static AccountRole Create(int roleId) => new AccountRole(roleId);
}
