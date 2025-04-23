using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Core.RequestResponse.Endpoints;

namespace ShopManagement.Core.RequestResponse.OrderItems.Command.Create
{
    public class CreateOrderItemCommand : ICommand<Guid>, IWebRequest
    {
        public int Id { get; set; }
        public long ProductId { get; set; }
        public int Count { get; set; }
        public double UnitPrice { get; set; }
        public int DiscountRate { get; set; }
        public long OrderId { get; set; }
        public string Path => "/api/OrderItem/Create";
    }
}
