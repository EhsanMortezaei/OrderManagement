using AccountManagement.Core.Contract.Permissions.Queries;
using AccountManagement.Core.RequestResponse.Permissions.Queries;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.RequestResponse.Queries;
using Zamin.Utilities;

namespace AccountManagement.Core.ApplicationService.Permissions.Queries.GetById;

public sealed class GetAccountByIdQueryHandler(ZaminServices zaminServices,
    IPermissionQueryRepository permissionQueryRepository) : QueryHandler<GetPermissionByIdQuery, PermissionQr?>(zaminServices)
{
    public override async Task<QueryResult<PermissionQr?>> Handle(GetPermissionByIdQuery query)
         => Result(await permissionQueryRepository.ExecuteAsync(query));
}
