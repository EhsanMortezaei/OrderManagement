using AccountManagement.Core.Contract.Accounts.Queries;
using AccountManagement.Core.RequestResponse.Accounts.Queries;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.RequestResponse.Queries;
using Zamin.Utilities;

namespace AccountManagement.Core.ApplicationService.Accounts.Queries.GetById
{
    public class GetAccountByIdQueryHandler : QueryHandler<GetAccountByIdQuery, AccountQr>
    {
        private readonly IAccountQueryRepository _accountQueryRepository;

        public GetAccountByIdQueryHandler(ZaminServices zaminServices,
            IAccountQueryRepository accountQueryRepository) : base(zaminServices)
        {
            _accountQueryRepository = accountQueryRepository;
        }

        public override async Task<QueryResult<AccountQr>> Handle(GetAccountByIdQuery query)
        {
            var account = await _accountQueryRepository.ExecuteAsync(query);

            return Result(account);
        }
    }
}
