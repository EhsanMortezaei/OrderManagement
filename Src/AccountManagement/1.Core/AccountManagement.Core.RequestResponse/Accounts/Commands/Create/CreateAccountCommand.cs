using Microsoft.AspNetCore.Http;
using Zamin.Core.RequestResponse.Commands;

namespace AccountManagement.Core.RequestResponse.Accounts.Commands.Create;

public sealed class CreateAccountCommand : ICommand<Guid>
{
    // null check shavad
    public string Fullname { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string ConfirmPassword { get; set; } = string.Empty;
    public string Mobile { get; set; } = string.Empty;
    public IFormFile ProfilePhoto { get; set; } = null!;
}
