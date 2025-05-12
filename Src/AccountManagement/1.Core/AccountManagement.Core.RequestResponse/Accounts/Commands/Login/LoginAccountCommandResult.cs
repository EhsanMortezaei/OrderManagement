namespace AccountManagement.Core.RequestResponse.Accounts.Commands.Login
{
    public sealed class LoginAccountCommandResult
    {
        public string? FullName { get; set; }
        public string? Username { get; set; }
        public string? Mobile { get; set; }

        public LoginAccountCommandResult(string? fullName, string? username, string? mobile)
        {
            FullName = fullName;
            Username = username;
            Mobile = mobile;
        }
    }
}
