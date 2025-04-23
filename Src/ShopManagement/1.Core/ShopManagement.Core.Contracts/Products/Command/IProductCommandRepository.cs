using ShopManagement.Core.Domain.Products.Entities;
using Zamin.Core.Contracts.Data.Commands;

namespace ShopManagement.Core.Contracts.Products.Command
{
    public interface IProductCommandRepository : ICommandRepository<Product, int>
    {
    }
}
