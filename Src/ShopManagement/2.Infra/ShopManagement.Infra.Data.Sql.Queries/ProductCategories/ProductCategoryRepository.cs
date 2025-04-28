using ShopManagement.Core.Contracts.Orders.Queries;
using ShopManagement.Infra.Data.Sql.Queries.Common;
using Zamin.Core.Contracts.Data.Queries;
using Zamin.Infra.Data.Sql.Queries;
using ShopManagement.Core.RequestResponse.Orders.Queries;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Core.RequestResponse.ProductCategories.Query;
using ShopManagement.Core.Contracts.ProductCategories.Queries;

namespace ShopManagement.Infra.Data.Sql.Queries.ProductCategories
{
    public class ProductCategoryRepository : BaseQueryRepository<ShopManagementQueryDbContext>, IProductCategoryQueryRepository
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
}
