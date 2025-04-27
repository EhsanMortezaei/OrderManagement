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
    [Route("api/[Controller]")]
    public class ShopController : BaseController
    {
        [HttpPost("CreateOrder")]
        public async Task<IActionResult> CreateOrder([FromBody] CreateOrderCommand command) => await Create<CreateOrderCommand, Guid>(command);

        [HttpPost("UpdateOrder")]
        public async Task<IActionResult> UpdateOrder([FromBody] UpdateOrderCommand command) => await Edit(command);

        [HttpPost("DeleteOrder")]
        public async Task<IActionResult> DeletOrder([FromBody] DeleteOrderCommand command) => await Delete(command);

        [HttpPost("CreateProductCategory")]
        public async Task<IActionResult> CreateProductCategory([FromBody] CreateProductCategoryCommand command) => await Create<CreateProductCategoryCommand, Guid>(command);

        [HttpPost("UpdateProductCategory")]
        public async Task<IActionResult> UpdateProductCategory([FromBody] UpdateProductCategoryCommand command) => await Edit(command);

        [HttpPost("DeleteProductCategory")]
        public async Task<IActionResult> DeleteProductCategory([FromBody] DeleteProductCategoryCommand command) => await Delete(command);

        [HttpPost("CreateProduct")]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductCommand command) => await Create<CreateProductCommand, Guid>(command);

        [HttpPost("UpdateProduct")]
        public async Task<IActionResult> UpdateProduct([FromBody] UpdateProductCommand command) => await Edit(command);

        [HttpPost("DeleteProduct")]
        public async Task<IActionResult> DeleteProduct([FromBody] DeleteProductCommand command) => await Delete(command);


        [HttpGet("GetByIdOrder")]
        public async Task<IActionResult> GetByIdOrder(GetOrderByIdQuery query) => await Query<GetOrderByIdQuery, OrderQr?>(query);

        [HttpGet("GetByIdProductCategory")]
        public async Task<IActionResult> GetByIdProductCategory(GetProductCategoryByIdQuery query) => await Query<GetProductCategoryByIdQuery, ProductCategoryQr?>(query);

        [HttpGet("GetByIdProduct")]
        public async Task<IActionResult> GetByIdProduct(GetProductByIdQuery query) => await Query<GetProductByIdQuery, ProductQr?>(query);
    }
}
