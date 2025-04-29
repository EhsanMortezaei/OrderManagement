namespace AccountManagement.Infra.Data.Sql.Queries.Permissions
{
    public class Permission
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public int RoleId { get; set; }
        public int AccountId { get; set; }
    }
}
