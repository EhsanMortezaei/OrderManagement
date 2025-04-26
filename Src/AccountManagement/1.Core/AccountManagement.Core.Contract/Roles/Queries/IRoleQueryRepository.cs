using AccountManagement.Core.RequestResponse.Roles.Queries;

namespace AccountManagement.Core.Contract.Roles.Queries
{
    public interface IRoleQueryRepository
    {
        public Task<RoleQr?> ExecuteAsync(GetRoleByIdQuery query);
    }
}
