namespace AccountManagement.Infra.Data.Sql.Queries.Accounts
{
    public class Account
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
        public string ProfilePhoto { get; set; }
        public int RoleId { get; set; }
    }
}
