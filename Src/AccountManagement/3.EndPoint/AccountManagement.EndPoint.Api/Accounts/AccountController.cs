using AccountManagement.Core.RequestResponse.Accounts.Commands.AddAccountRole;
using AccountManagement.Core.RequestResponse.Accounts.Commands.Create;
using AccountManagement.Core.RequestResponse.Accounts.Commands.Delete;
using AccountManagement.Core.RequestResponse.Accounts.Commands.Login;
using AccountManagement.Core.RequestResponse.Accounts.Commands.RemoveAccountRole;
using AccountManagement.Core.RequestResponse.Accounts.Commands.Update;
using AccountManagement.Core.RequestResponse.Accounts.Queries.GetAccountById;
using AccountManagement.Core.RequestResponse.Roles.Commands.AddPermission;
using AccountManagement.Core.RequestResponse.Roles.Commands.Create;
using AccountManagement.Core.RequestResponse.Roles.Commands.Delete;
using AccountManagement.Core.RequestResponse.Roles.Commands.RemovePermission;
using AccountManagement.Core.RequestResponse.Roles.Commands.Update;
using AccountManagement.Core.RequestResponse.Roles.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Zamin.EndPoints.Web.Controllers;

namespace AccountManagement.EndPoint.Api.Accounts;

// name action eslah shavad
// har aggregate yek controller darad
[Route("api/AccountManagement/[controller]/[action]")]
public sealed class AccountController : BaseController
{
    readonly IMediator _mediator;

    public AccountController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> Create([FromForm] CreateAccountCommand command) => await Create<CreateAccountCommand, Guid>(command);

    [HttpPut("UpdateAccount")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> Update([FromForm] UpdateAccountCommand command) => await Edit(command);

    [HttpDelete("DeleteAccount")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> DeleteAccount([FromBody] DeleteAccountCommand command) => await Delete(command);


    [HttpPost("AddAccountRole")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> AddAccountRole([FromBody] AddAccountRoleCommand command) => await Create(command);

    [HttpDelete("RemoveAccountRole")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> RemoveAccountRole([FromBody] RemoveAccountRoleCommand command) => await Delete(command);

    [HttpPost("CreateRole")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> CreateRole([FromBody] CreateRoleCommand command) => await Create<CreateRoleCommand, Guid>(command);

    [HttpPut("UpdateRole")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> UpdateRole([FromBody] UpdateRoleCommand command) => await Edit(command);

    [HttpDelete("DeleteRole")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> DeleteRole([FromBody] DeleteRoleCommand command) => await Delete(command);

    [HttpPost("Login")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> Login([FromBody] LoginAccountCommand command)
        => await Create<LoginAccountCommand, LoginAccountCommandResult>(command);
    //public async Task<IActionResult> Login([FromBody] LoginAccountCommand command)
    //{
    //    var result = await _mediator.Send(command);
    //    return Ok(result);
    //}

    //[HttpPost("CreatePermission")]
    //public async Task<IActionResult> CreatePermission([FromBody] CreatePermissionCommand command) => await Create<CreatePermissionCommand, Guid>(command);

    //[HttpPut("UpdatePermission")]
    //public async Task<IActionResult> UpdeatePermission([FromBody] UpdatePermissionCommand command) => await Edit(command);

    //[HttpDelete("DeletePermission")]
    //public async Task<IActionResult> DeletePermission([FromBody] DeletePermissionCommand command) => await Delete(command);

    [HttpPost("AddPermission")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> AddPermission([FromBody] AddPermissionCommand command) => await Create(command);

    [HttpDelete("RemovePermission")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> RemovePermission([FromBody] RemovePermissionCommand command) => await Delete(command);

    [HttpGet("GetByIdAccount")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> GetByIdAccount([FromQuery] GetAccountByIdQuery query) => await Query<GetAccountByIdQuery, AccountQr?>(query);

    [HttpGet("GetByIdRole")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> GetByIdRole([FromQuery] GetRoleByIdQuery query) => await Query<GetRoleByIdQuery, RoleQr?>(query);
}
