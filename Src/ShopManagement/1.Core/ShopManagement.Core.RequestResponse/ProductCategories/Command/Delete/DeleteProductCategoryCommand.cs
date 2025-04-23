using Zamin.Core.RequestResponse.Commands;
using Zamin.Core.RequestResponse.Endpoints;

namespace ShopManagement.Core.RequestResponse.ProductCategories.Command.Delete
{
    public class DeleteProductCategoryCommand : ICommand, IWebRequest
    {
        public int Id { get; set; }

        public string Path => "/api/Product/Delete";
    }
}
