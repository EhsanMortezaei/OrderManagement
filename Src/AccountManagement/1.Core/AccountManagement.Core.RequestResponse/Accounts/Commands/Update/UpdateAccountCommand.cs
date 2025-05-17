using Microsoft.AspNetCore.Http;
using Zamin.Core.RequestResponse.Commands;

namespace AccountManagement.Core.RequestResponse.Accounts.Commands.Update;

public sealed class UpdateAccountCommand : ICommand
{
    public int Id { get; set; }
    public string Fullname { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Mobile { get; set; } = string.Empty;
    public IFormFile ProfilePhoto { get; set; } = null!;
}

