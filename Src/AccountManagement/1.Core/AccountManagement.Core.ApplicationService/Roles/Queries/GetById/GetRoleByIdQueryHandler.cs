using AccountManagement.Core.Contract.Roles.Queries;
using AccountManagement.Core.RequestResponse.Roles.Queries;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.RequestResponse.Queries;
using Zamin.Utilities;

namespace AccountManagement.Core.ApplicationService.Roles.Queries.GetById;

public sealed class GetRoleByIdQueryHandler(ZaminServices zaminServices,
    IRoleQueryRepository roleQueryRepository) : QueryHandler<GetRoleByIdQuery, RoleQr?>(zaminServices)
{
    public override async Task<QueryResult<RoleQr?>> Handle(GetRoleByIdQuery query)
         => Result(await roleQueryRepository.ExecuteAsync(query));
}
