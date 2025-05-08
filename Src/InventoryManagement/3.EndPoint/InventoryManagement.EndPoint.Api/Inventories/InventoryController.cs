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

namespace InventoryManagement.EndPoint.Api.Inventories
{
    [Route("api/[controller]")]
    public class InventoryController : BaseController
    {
        [HttpPost("CreateInventory")]
        public async Task<IActionResult> CreateInventory([FromBody] CreateInventoryCommand command) => await Create<CreateInventoryCommand, Guid>(command);

        [HttpPut("UpdateInventory")]
        public async Task<IActionResult> UpdateInventory([FromBody] UpdateInventoryCommand command) => await Edit(command);

        [HttpDelete("DeleteInventory")]
        public async Task<IActionResult> DeleteInventory([FromBody] DeleteInventoryCommand command) => await Delete(command);

        [HttpPost("IncreaseInventory")]
        public async Task<IActionResult> IncreaseInventory([FromBody] IncreaseInventoryCommand command) => await Create<IncreaseInventoryCommand, Guid>(command);

        [HttpPost("ReduceInventory")]
        public async Task<IActionResult> ReduceInventory([FromBody] ReduceInventoryCommand command) => await Create<ReduceInventoryCommand, Guid>(command);

        [HttpPost("CreateInventoryOperation")]
        public async Task<IActionResult> CreateInventoryOperation([FromBody] CreateInventoryOperationCommand command) => await Create<CreateInventoryOperationCommand, Guid>(command);

        [HttpPut("UpdateInventoryOperation")]
        public async Task<IActionResult> UpdateInventoryOperation([FromBody] UpdateInventoryOperationCommand command) => await Edit(command);

        [HttpDelete("DeleteInventoryOperation")]
        public async Task<IActionResult> DeleteInventoryOperation([FromBody] DeleteInventoryOperationCommand command) => await Delete(command);


        [HttpGet("GetByIdInnventory")]
        public async Task<IActionResult> GetByIdInventory([FromQuery] GetInventoryByIdQuery query) => await Query<GetInventoryByIdQuery, InventoryQr?>(query);

        [HttpGet("GetByIdInventoryOperation")]
        public async Task<IActionResult> GetByIdInventoryOperation([FromQuery] GetInventoryOperationByIdQuery query) => await Query<GetInventoryOperationByIdQuery, InventoryOperationQr?>(query);
    }
}
