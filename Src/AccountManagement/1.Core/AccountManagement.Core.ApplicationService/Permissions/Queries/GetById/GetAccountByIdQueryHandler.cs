using AccountManagement.Core.Contract.Permissions.Queries;
using AccountManagement.Core.RequestResponse.Permissions.Queries;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.RequestResponse.Queries;
using Zamin.Utilities;

namespace AccountManagement.Core.ApplicationService.Permissions.Queries.GetById;

public sealed class GetAccountByIdQueryHandler : QueryHandler<GetPermissionByIdQuery, PermissionQr?>
{
    readonly IPermissionQueryRepository _permissionQueryRepository;

    public GetAccountByIdQueryHandler(ZaminServices zaminServices,
        IPermissionQueryRepository permissionQueryRepository) : base(zaminServices)
    {
        _permissionQueryRepository = permissionQueryRepository;
    }

    public override async Task<QueryResult<PermissionQr?>> Handle(GetPermissionByIdQuery query)
         => Result(await _permissionQueryRepository.ExecuteAsync(query));
}
