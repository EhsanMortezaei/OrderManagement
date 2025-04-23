using Zamin.Core.RequestResponse.Commands;
using Zamin.Core.RequestResponse.Endpoints;

namespace ShopManagement.Core.RequestResponse.Orders.Command.Update
{
    public class UpdateOrderCommand : ICommand, IWebRequest
    {
        public int Id { get; set; }
        public long AccountId { get; set; }
        public int PaymentMethod { get; set; }
        public double TotalAmount { get; set; }
        public double DiscountAmount { get; set; }
        public double PayAmount { get; set; }
        public bool IsPaid { get; set; }
        public bool IsCanceled { get; set; }
        public string IssueTrackingNo { get; set; }
        public long RefId { get; set; }

        public string Path => "/api/Order/Update";
    }
}
