using ShopManagement.Core.Contracts.Products.Command;
using ShopManagement.Core.Domain.Products.Entities;
using ShopManagement.Infra.Data.Sql.Commands.Common;
using Zamin.Infra.Data.Sql.Commands;

namespace ShopManagement.Infra.Data.Sql.Commands.Products;

public sealed class ProductCommandRepository :
    BaseCommandRepository<Product, ShopManagementCommandDbContext, int>,
    IProductCommandRepository
{
    public ProductCommandRepository(ShopManagementCommandDbContext dbContext) : base(dbContext)
    {
    }
}
