using Microsoft.EntityFrameworkCore;
using ShopManagement.Core.Contracts.Orders.Queries;
using ShopManagement.Core.Contracts.Products.Queries;
using ShopManagement.Core.RequestResponse.ProductCategories.Query;
using ShopManagement.Core.RequestResponse.Products.Query;
using ShopManagement.Infra.Data.Sql.Queries.Common;
using Zamin.Infra.Data.Sql.Queries;

namespace ShopManagement.Infra.Data.Sql.Queries.Products
{
    public class ProductRepository : BaseQueryRepository<ShopManagementQueryDbContext>, IProductQueryRepository
    {
        public ProductRepository(ShopManagementQueryDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<ProductQr?> ExecuteAsync(GetProductByIdQuery query)
        => await _dbContext.Products.Select(c => new ProductQr()
        {
            Id = c.Id,
            Name = c.Name,
            Code = c.Code,
            ShortDescription = c.ShortDescription,
            Descrption = c.Descrption,
            Picture = c.Picture,
            PictureAlt = c.PictureAlt,
            PictureTitle = c.PictureTitle,
            CategoryId = c.CategoryId,
            Slug = c.Slug,
            Keywords = c.Keywords,
            MetaDescription = c.MetaDescription,

        }).FirstOrDefaultAsync(c => c.Id.Equals(query.ProductId));
    }
}
