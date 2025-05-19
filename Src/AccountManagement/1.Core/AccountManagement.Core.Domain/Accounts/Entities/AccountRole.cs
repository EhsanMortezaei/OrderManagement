using Zamin.Core.Domain.Entities;

namespace AccountManagement.Core.Domain.Accounts.Entities;

public sealed class AccountRole : Entity<int>
{
    #region Properties
    public int AccountId { get; private set; }
    public int RoleId { get; private set; }
    #endregion

    #region Constructors
    private AccountRole() { }

    public AccountRole(int roleId) => RoleId = roleId;
    #endregion

    #region Commands
    public static AccountRole Create(int roleId) => new(roleId);
    #endregion
}
