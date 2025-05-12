using Zamin.Core.RequestResponse.Commands;

namespace AccountManagement.Core.RequestResponse.Accounts.Commands.Login;

public sealed class LoginAccountCommand : ICommand<LoginAccountCommandResult>
{
    public string UserName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}
