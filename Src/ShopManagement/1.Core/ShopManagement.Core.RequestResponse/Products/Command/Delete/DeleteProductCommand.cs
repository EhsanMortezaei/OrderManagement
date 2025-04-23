using Zamin.Core.RequestResponse.Commands;
using Zamin.Core.RequestResponse.Endpoints;

namespace ShopManagement.Core.RequestResponse.Products.Command.Delete
{
    public class DeleteProductCommand : ICommand, IWebRequest
    {
        public int Id { get; set; }
        public string Path => "/api/Product/Delete";
    }
}
