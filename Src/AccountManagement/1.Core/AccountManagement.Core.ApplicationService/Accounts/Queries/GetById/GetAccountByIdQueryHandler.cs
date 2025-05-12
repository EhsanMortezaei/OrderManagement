using AccountManagement.Core.Contract.Accounts.Queries;
using AccountManagement.Core.RequestResponse.Accounts.Queries.GetAccountById;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.RequestResponse.Queries;
using Zamin.Utilities;

namespace AccountManagement.Core.ApplicationService.Accounts.Queries.GetById;
// sade shavad
public sealed class GetAccountByIdQueryHandler(ZaminServices zaminServices,
    IAccountQueryRepository accountQueryRepository) : QueryHandler<GetAccountByIdQuery, AccountQr?>(zaminServices)
{
    public override async Task<QueryResult<AccountQr?>> Handle(GetAccountByIdQuery query)
        => Result(await accountQueryRepository.ExecuteAsync(query));
}
