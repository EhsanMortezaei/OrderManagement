using ShopManagement.Core.Contracts.ProductCategories.Command;
using ShopManagement.Core.Domain.ProductCategories.Entities;
using ShopManagement.Infra.Data.Sql.Commands.Common;
using Zamin.Infra.Data.Sql.Commands;

namespace ShopManagement.Infra.Data.Sql.Commands.ProductCategories;

public sealed class ProductCategoryCommandRepository(ShopManagementCommandDbContext dbContext) :
    BaseCommandRepository<ProductCategory, ShopManagementCommandDbContext, int>(dbContext),
    IProductCategoryCommandRepository
{
}
