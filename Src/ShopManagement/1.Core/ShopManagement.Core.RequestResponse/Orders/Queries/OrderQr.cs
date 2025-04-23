namespace ShopManagement.Core.RequestResponse.Orders.Queries
{
    public class OrderQr
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
    }
}
