using Zamin.Core.RequestResponse.Queries;

namespace AccountManagement.Core.RequestResponse.Accounts.Queries.GetAccountById;

public sealed class GetAccountByIdQuery : IQuery<AccountQr?>
{
    public int AccountId { get; set; }
}
