using InventoryManagement.Core.RequestResponse.Inventories.Commands.Create;
using InventoryManagement.Core.RequestResponse.Inventories.Commands.Delet;
using InventoryManagement.Core.RequestResponse.Inventories.Commands.IncreaseInventory;
using InventoryManagement.Core.RequestResponse.Inventories.Commands.ReduceInventory;
using InventoryManagement.Core.RequestResponse.Inventories.Commands.Update;
using InventoryManagement.Core.RequestResponse.Inventories.Queries;
using InventoryManagement.Core.RequestResponse.InventoryOperations.Commands.Create;
using InventoryManagement.Core.RequestResponse.InventoryOperations.Commands.Delete;
using InventoryManagement.Core.RequestResponse.InventoryOperations.Commands.Update;
using InventoryManagement.Core.RequestResponse.InventoryOperations.Queries;
using Microsoft.AspNetCore.Mvc;
using Zamin.EndPoints.Web.Controllers;

namespace InventoryManagement.EndPoint.Api.Inventories;

[Route("api/InventoryManagement/[controller]/[action]")]
public sealed class InventoryController : BaseController
{
    #region Commands
    [HttpPost("CreateInventory")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> CreateInventory([FromForm] CreateInventoryCommand command) => await Create<CreateInventoryCommand, Guid>(command);

    [HttpPut("UpdateInventory")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> UpdateInventory([FromForm] UpdateInventoryCommand command) => await Edit(command);

    [HttpDelete("DeleteInventory")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> DeleteInventory([FromForm] DeleteInventoryCommand command) => await Delete(command);

    [HttpPost("IncreaseInventory")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> IncreaseInventory([FromForm] IncreaseInventoryCommand command) => await Create<IncreaseInventoryCommand, Guid>(command);

    [HttpPost("ReduceInventory")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> ReduceInventory([FromForm] ReduceInventoryCommand command) => await Create<ReduceInventoryCommand, Guid>(command);

    [HttpPost("CreateInventoryOperation")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> CreateInventoryOperation([FromForm] CreateInventoryOperationCommand command) => await Create<CreateInventoryOperationCommand, Guid>(command);

    [HttpPut("UpdateInventoryOperation")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> UpdateInventoryOperation([FromForm] UpdateInventoryOperationCommand command) => await Edit(command);

    [HttpDelete("DeleteInventoryOperation")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> DeleteInventoryOperation([FromForm] DeleteInventoryOperationCommand command) => await Delete(command);
    #endregion

    #region Queries
    [HttpGet("GetByIdInnventory")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> GetByIdInventory([FromQuery] GetInventoryByIdQuery query) => await Query<GetInventoryByIdQuery, InventoryQr?>(query);

    [HttpGet("GetByIdInventoryOperation")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> GetByIdInventoryOperation([FromQuery] GetInventoryOperationByIdQuery query) => await Query<GetInventoryOperationByIdQuery, InventoryOperationQr?>(query);
    #endregion
}
