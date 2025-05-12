using Zamin.Core.RequestResponse.Commands;

namespace AccountManagement.Core.RequestResponse.Accounts.Commands.Delete;

// sealed record
// Path, IWebRequest hazf shavad
public sealed record DeleteAccountCommand : ICommand
{
    public int Id { get; set; }
}
