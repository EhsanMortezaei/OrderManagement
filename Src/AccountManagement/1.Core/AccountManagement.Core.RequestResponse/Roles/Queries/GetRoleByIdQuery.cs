using Zamin.Core.RequestResponse.Queries;

namespace AccountManagement.Core.RequestResponse.Roles.Queries;

public sealed class GetRoleByIdQuery : IQuery<RoleQr?>
{
    public int RoleId { get; set; }
}
