using Zamin.Core.RequestResponse.Queries;

namespace AccountManagement.Core.RequestResponse.Permissions.Queries;

public sealed class GetPermissionByIdQuery : IQuery<PermissionQr?>
{
    public int PermissionId { get; set; }
}
