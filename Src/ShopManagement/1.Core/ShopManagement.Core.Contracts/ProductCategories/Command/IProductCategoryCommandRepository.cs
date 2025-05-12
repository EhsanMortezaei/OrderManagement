using ShopManagement.Core.Domain.ProductCategories.Entities;
using Zamin.Core.Contracts.Data.Commands;

namespace ShopManagement.Core.Contracts.ProductCategories.Command;

public interface IProductCategoryCommandRepository : ICommandRepository<ProductCategory, int>
{
}
