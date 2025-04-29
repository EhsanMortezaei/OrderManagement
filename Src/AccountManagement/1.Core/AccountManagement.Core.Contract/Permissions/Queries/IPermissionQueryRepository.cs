using AccountManagement.Core.RequestResponse.Permissions.Queries;

namespace AccountManagement.Core.Contract.Permissions.Queries
{
    public interface IPermissionQueryRepository
    {
        public Task<PermissionQr?> ExecuteAsync(GetPermissionByIdQuery query);
    }
}
