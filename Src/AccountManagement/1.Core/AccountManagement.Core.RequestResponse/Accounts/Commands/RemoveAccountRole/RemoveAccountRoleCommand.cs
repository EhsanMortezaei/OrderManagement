using Zamin.Core.RequestResponse.Commands;

namespace AccountManagement.Core.RequestResponse.Accounts.Commands.RemoveAccountRole;

public sealed class RemoveAccountRoleCommand : ICommand
{
    public int AccountId { get; set; }
    public int RoleId { get; set; }
}

