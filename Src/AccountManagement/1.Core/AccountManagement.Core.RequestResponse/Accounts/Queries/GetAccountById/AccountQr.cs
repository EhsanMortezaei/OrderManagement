namespace AccountManagement.Core.RequestResponse.Accounts.Queries.GetAccountById;

public sealed class AccountQr
{
    public int Id { get; set; }
    public string Fullname { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Mobile { get; set; } = string.Empty;
    public string ProfilePhoto { get; set; } = string.Empty;
}
