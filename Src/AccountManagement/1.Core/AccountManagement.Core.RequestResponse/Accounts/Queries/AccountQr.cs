namespace AccountManagement.Core.RequestResponse.Accounts.Queries
{
    public class AccountQr
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
        public int RoleId { get; set; }
        public string ProfilePhoto { get; set; }
    }
}
