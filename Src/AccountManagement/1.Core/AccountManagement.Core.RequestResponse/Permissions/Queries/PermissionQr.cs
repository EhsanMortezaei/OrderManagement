namespace AccountManagement.Core.RequestResponse.Permissions.Queries;

public sealed class PermissionQr
{
    public int Id { get; set; }
    public int Code { get; set; }
    public string Name { get; set; } = string.Empty;
    public int RoleId { get; set; }
}
