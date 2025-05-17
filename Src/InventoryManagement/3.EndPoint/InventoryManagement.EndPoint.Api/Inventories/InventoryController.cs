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
    [HttpPost("CreateInventory")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> CreateInventory([FromBody] CreateInventoryCommand command) => await Create<CreateInventoryCommand, Guid>(command);

    [HttpPut("UpdateInventory")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> UpdateInventory([FromBody] UpdateInventoryCommand command) => await Edit(command);

    [HttpDelete("DeleteInventory")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> DeleteInventory([FromBody] DeleteInventoryCommand command) => await Delete(command);

    [HttpPost("IncreaseInventory")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> IncreaseInventory([FromBody] IncreaseInventoryCommand command) => await Create<IncreaseInventoryCommand, Guid>(command);

    [HttpPost("ReduceInventory")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> ReduceInventory([FromBody] ReduceInventoryCommand command) => await Create<ReduceInventoryCommand, Guid>(command);

    [HttpPost("CreateInventoryOperation")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> CreateInventoryOperation([FromBody] CreateInventoryOperationCommand command) => await Create<CreateInventoryOperationCommand, Guid>(command);

    [HttpPut("UpdateInventoryOperation")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> UpdateInventoryOperation([FromBody] UpdateInventoryOperationCommand command) => await Edit(command);

    [HttpDelete("DeleteInventoryOperation")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> DeleteInventoryOperation([FromBody] DeleteInventoryOperationCommand command) => await Delete(command);


    [HttpGet("GetByIdInnventory")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> GetByIdInventory([FromQuery] GetInventoryByIdQuery query) => await Query<GetInventoryByIdQuery, InventoryQr?>(query);

    [HttpGet("GetByIdInventoryOperation")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> GetByIdInventoryOperation([FromQuery] GetInventoryOperationByIdQuery query) => await Query<GetInventoryOperationByIdQuery, InventoryOperationQr?>(query);
}
