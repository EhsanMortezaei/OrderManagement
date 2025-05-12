using Microsoft.EntityFrameworkCore;
using ShopManagement.Core.Contracts.ProductCategories.Queries;
using ShopManagement.Core.RequestResponse.ProductCategories.Query;
using ShopManagement.Infra.Data.Sql.Queries.Common;
using Zamin.Infra.Data.Sql.Queries;

namespace ShopManagement.Infra.Data.Sql.Queries.ProductCategories;

public sealed class ProductCategoryRepository : BaseQueryRepository<ShopManagementQueryDbContext>, IProductCategoryQueryRepository
{
    public ProductCategoryRepository(ShopManagementQueryDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<ProductCategoryQr?> ExecuteAsync(GetProductCategoryByIdQuery query)
    => await _dbContext.ProductCategories.Select(c => new ProductCategoryQr()
    {
        Id = c.Id,
        Name = c.Name,
        Description = c.Description,
        Picture = c.Picture,
        PictureAlt = c.PictureAlt,
        PictureTitle = c.PictureTitle,
        KeyWords = c.KeyWords,
        MetaDescription = c.MetaDescription,
        Slug = c.Slug,

    }).FirstOrDefaultAsync(c => c.Id.Equals(query.ProductCategoryId));
}
