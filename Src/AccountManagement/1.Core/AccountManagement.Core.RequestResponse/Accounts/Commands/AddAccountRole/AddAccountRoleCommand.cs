using Zamin.Core.RequestResponse.Commands;

namespace AccountManagement.Core.RequestResponse.Accounts.Commands.AddAccountRole;

public sealed class AddAccountRoleCommand : ICommand
{
    public int AccountId { get; set; }
    public int RoleId { get; set; }
}
