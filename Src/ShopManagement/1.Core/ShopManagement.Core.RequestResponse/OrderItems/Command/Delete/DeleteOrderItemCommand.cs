using Zamin.Core.RequestResponse.Commands;
using Zamin.Core.RequestResponse.Endpoints;

namespace ShopManagement.Core.RequestResponse.OrderItems.Command.Delete
{
    public class DeleteOrderItemCommand : ICommand, IWebRequest
    {
        public int Id { get; set; }

        public string Path => "/api/OrderItem/Delete";
    }
}
