using AccountManagement.Core.Domain.Permissions.Event;
using AccountManagement.Core.RequestResponse.Accounts.Commands.Create;
using AccountManagement.Core.RequestResponse.Accounts.Commands.Delete;
using AccountManagement.Core.RequestResponse.Accounts.Commands.Login;
using AccountManagement.Core.RequestResponse.Accounts.Commands.Update;
using AccountManagement.Core.RequestResponse.Accounts.Queries;
using AccountManagement.Core.RequestResponse.Permissions.Commands.Create;
using AccountManagement.Core.RequestResponse.Permissions.Commands.Delete;
using AccountManagement.Core.RequestResponse.Permissions.Commands.Update;
using AccountManagement.Core.RequestResponse.Roles.Commands.Create;
using AccountManagement.Core.RequestResponse.Roles.Commands.Delete;
using AccountManagement.Core.RequestResponse.Roles.Commands.Update;
using AccountManagement.Core.RequestResponse.Roles.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Zamin.EndPoints.Web.Controllers;

namespace AccountManagement.EndPoint.Api.Accounts
{
    [Route("api/[controller]")]
    public class AccountController : BaseController
    {
        private readonly IMediator _mediator;

        public AccountController(IMediator mediator)
        {
            _mediator = mediator;
        }

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

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginAccountCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPost("CreatePermission")]
        public async Task<IActionResult> CreatePermission([FromBody] CreatePermissionCommand command) => await Create<CreatePermissionCommand, Guid>(command);

        [HttpPost("UpdatePermission")]
        public async Task<IActionResult> UpdeatePermission([FromBody] UpdatePermissionCommand command) => await Edit(command);

        [HttpPost("DeletePermission")]
        public async Task<IActionResult> DeletePermission([FromBody] DeletePermissionCommand command) => await Delete(command);

        [HttpGet("GetByIdAccount")]
        public async Task<IActionResult> GetByIdAccount(GetAccountByIdQuery query) => await Query<GetAccountByIdQuery, AccountQr?>(query);

        [HttpGet("GetByIdRole")]
        public async Task<IActionResult> GetByIdRole(GetRoleByIdQuery query) => await Query<GetRoleByIdQuery, RoleQr?>(query);
    }
}
