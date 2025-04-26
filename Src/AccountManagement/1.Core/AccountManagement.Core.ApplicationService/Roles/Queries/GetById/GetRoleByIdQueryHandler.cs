using AccountManagement.Core.Contract.Roles.Queries;
using AccountManagement.Core.RequestResponse.Roles.Queries;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.RequestResponse.Queries;
using Zamin.Utilities;

namespace AccountManagement.Core.ApplicationService.Roles.Queries.GetById
{
    public class GetRoleByIdQueryHandler : QueryHandler<GetRoleByIdQuery, RoleQr>
    {
        private readonly IRoleQueryRepository _roleQueryRepository;

        public GetRoleByIdQueryHandler(ZaminServices zaminServices,
            IRoleQueryRepository roleQueryRepository) : base(zaminServices)
        {
            _roleQueryRepository = roleQueryRepository;
        }

        public override async Task<QueryResult<RoleQr>> Handle(GetRoleByIdQuery query)
        {
            var role = await _roleQueryRepository.ExecuteAsync(query);
            return Result(role);
        }
    }
}
