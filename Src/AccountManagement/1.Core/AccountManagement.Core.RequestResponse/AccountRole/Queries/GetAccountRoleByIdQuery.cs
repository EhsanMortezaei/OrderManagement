using Zamin.Core.RequestResponse.Queries;

namespace AccountManagement.Core.RequestResponse.AccountRole.Queries;

public sealed class GetAccountRoleByIdQuery : IQuery<AccountRoleQr?>
{
    public int AccountRoleId { get; set; }
}
