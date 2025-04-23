using Zamin.Core.RequestResponse.Commands;
using Zamin.Core.RequestResponse.Endpoints;

namespace ShopManagement.Core.RequestResponse.Orders.Command.Delete
{
    public class DeleteOrderCommand : ICommand, IWebRequest
    {
        public int Id { get; set; }

        public string Path => "/api/Order/Delete";
    }
}
