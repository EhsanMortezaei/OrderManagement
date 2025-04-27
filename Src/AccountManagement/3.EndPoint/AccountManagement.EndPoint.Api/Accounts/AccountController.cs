using AccountManagement.Core.RequestResponse.Accounts.Commands.Create;
using AccountManagement.Core.RequestResponse.Accounts.Commands.Delete;
using AccountManagement.Core.RequestResponse.Accounts.Commands.Update;
using AccountManagement.Core.RequestResponse.Accounts.Queries;
using AccountManagement.Core.RequestResponse.Roles.Commands.Create;
using AccountManagement.Core.RequestResponse.Roles.Commands.Delete;
using AccountManagement.Core.RequestResponse.Roles.Commands.Update;
using AccountManagement.Core.RequestResponse.Roles.Queries;
using Microsoft.AspNetCore.Mvc;
using Zamin.EndPoints.Web.Controllers;

namespace AccountManagement.EndPoint.Api.Accounts
{
    [Route("api/[controller]")]
    public class AccountController : BaseController
    {
        [HttpPost("CreateAccount")]
        public async Task<IActionResult> CreateAccount([FromBody] CreateAccountCommand command) => await Create<CreateAccountCommand, Guid>(command);

        [HttpPost("UpdateAccount")]
        public async Task<IActionResult> UpdateAccount([FromBody] UpdateAccountCommand command) => await Edit(command);

        [HttpDelete("DeleteAccount")]
        public async Task<IActionResult> DeleteAccount([FromBody] DeleteAccountCommand command) => await Delete(command);


        [HttpPost("CreateRole")]
        public async Task<IActionResult> DeleteRole([FromBody] CreateRoleCommand command) => await Create<CreateRoleCommand, Guid>(command);

        [HttpPost("UpdateRole")]
        public async Task<IActionResult> UpdateRole([FromBody] UpdateRoleCommand command) => await Edit(command);

        [HttpPost("DeleteRole")]
        public async Task<IActionResult> DeleteRole([FromBody] DeleteRoleCommand command) => await Delete(command);


        [HttpGet("GetByIdAccount")]
        public async Task<IActionResult> GetByIdAccount(GetAccountByIdQuery query) => await Query<GetAccountByIdQuery, AccountQr?>(query);

        [HttpGet("GetByIdRole")]
        public async Task<IActionResult> GetByIdRole(GetRoleByIdQuery query) => await Query<GetRoleByIdQuery, RoleQr?>(query);
    }
}
