using Microsoft.AspNetCore.Mvc;
using ShopManagement.Core.RequestResponse.Orders.Command.Create;
using ShopManagement.Core.RequestResponse.Orders.Command.Delete;
using ShopManagement.Core.RequestResponse.Orders.Command.Update;
using ShopManagement.Core.RequestResponse.Orders.Queries;
using ShopManagement.Core.RequestResponse.ProductCategories.Command.Create;
using ShopManagement.Core.RequestResponse.ProductCategories.Command.Delete;
using ShopManagement.Core.RequestResponse.ProductCategories.Command.Update;
using ShopManagement.Core.RequestResponse.ProductCategories.Query;
using ShopManagement.Core.RequestResponse.Products.Command.Create;
using ShopManagement.Core.RequestResponse.Products.Command.Delete;
using ShopManagement.Core.RequestResponse.Products.Command.Update;
using ShopManagement.Core.RequestResponse.Products.Query;
using Zamin.EndPoints.Web.Controllers;

namespace ShopManagement.EndPoint.Api.Shops
{
    [Route("api/ShopManagement/[controller]/[action]")]
    public sealed class ShopController : BaseController
    {
        [HttpPost("CreateOrder")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> CreateOrder([FromBody] CreateOrderCommand command) => await Create<CreateOrderCommand, Guid>(command);

        [HttpPut("UpdateOrder")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> UpdateOrder([FromBody] UpdateOrderCommand command) => await Edit(command);

        [HttpDelete("DeleteOrder")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> DeletOrder([FromBody] DeleteOrderCommand command) => await Delete(command);

        [HttpPost("CreateProductCategory")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> CreateProductCategory([FromForm] CreateProductCategoryCommand command) => await Create<CreateProductCategoryCommand, Guid>(command);

        [HttpPut("UpdateProductCategory")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> UpdateProductCategory([FromForm] UpdateProductCategoryCommand command) => await Edit(command);

        [HttpDelete("DeleteProductCategory")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> DeleteProductCategory([FromBody] DeleteProductCategoryCommand command) => await Delete(command);

        [HttpPost("CreateProduct")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> CreateProduct([FromForm] CreateProductCommand command) => await Create<CreateProductCommand, Guid>(command);

        [HttpPut("UpdateProduct")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> UpdateProduct([FromForm] UpdateProductCommand command) => await Edit(command);

        [HttpDelete("DeleteProduct")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> DeleteProduct([FromBody] DeleteProductCommand command) => await Delete(command);


        [HttpGet("GetByIdOrder")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> GetByIdOrder(GetOrderByIdQuery query) => await Query<GetOrderByIdQuery, OrderQr?>(query);

        [HttpGet("GetByIdProductCategory")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> GetByIdProductCategory(GetProductCategoryByIdQuery query) => await Query<GetProductCategoryByIdQuery, ProductCategoryQr?>(query);

        [HttpGet("GetByIdProduct")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> GetByIdProduct(GetProductByIdQuery query) => await Query<GetProductByIdQuery, ProductQr?>(query);
    }
}
