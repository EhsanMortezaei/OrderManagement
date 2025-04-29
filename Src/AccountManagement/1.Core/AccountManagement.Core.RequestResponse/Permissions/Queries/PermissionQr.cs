namespace AccountManagement.Core.RequestResponse.Permissions.Queries
{
    public class PermissionQr
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public int RoleId { get; set; }
        public int AccountId { get; set; }
    }
}
