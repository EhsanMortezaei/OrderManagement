using AccountManagement.Core.RequestResponse.Accounts.Queries.GetAccountById;

namespace AccountManagement.Core.Contract.Accounts.Queries;

public interface IAccountQueryRepository
{
    public Task<AccountQr?> ExecuteAsync(GetAccountByIdQuery query);
}
