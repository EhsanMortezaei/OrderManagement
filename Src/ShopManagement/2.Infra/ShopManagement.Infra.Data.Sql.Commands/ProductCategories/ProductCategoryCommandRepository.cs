using ShopManagement.Core.Contracts.ProductCategories.Command;
using ShopManagement.Core.Domain.ProductCategories.Entities;
using ShopManagement.Infra.Data.Sql.Commands.Common;
using Zamin.Infra.Data.Sql.Commands;

namespace ShopManagement.Infra.Data.Sql.Commands.ProductCategories;

public class ProductCategoryCommandRepository :
    BaseCommandRepository<ProductCategory, ShopManagementCommandDbContext, int>,
    IProductCategoryCommandRepository
{
    public ProductCategoryCommandRepository(ShopManagementCommandDbContext dbContext) : base(dbContext)
    {
    }
}
