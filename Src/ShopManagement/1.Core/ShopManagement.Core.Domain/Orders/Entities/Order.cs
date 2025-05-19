using Zamin.Core.Domain.Entities;

namespace ShopManagement.Core.Domain.Orders.Entities;

public sealed class Order : AggregateRoot<int>
{
    #region Properties
    public long AccountId { get; private set; }
    public int PaymentMethod { get; private set; }
    public double TotalAmount { get; private set; }
    public double DiscountAmount { get; private set; }
    public double PayAmount { get; private set; }
    public bool IsPaid { get; private set; }
    public bool IsCanceled { get; private set; }
    public string IssueTrackingNo { get; private set; } = string.Empty;
    public long RefId { get; private set; }
    public List<OrderItem> Items { get; private set; } = new List<OrderItem>();
    #endregion

    #region Constructors
    private Order() { }

    public Order(List<OrderItem> items)
    {
        Items = items;
    }

    public Order(long accountId,
                 int paymentMethod,
                 double totalAmount,
                 double discountAmount,
                 double payAmount,
                 string issueTrackingNo,
                 List<OrderItem> items)
    {
        AccountId = accountId;
        TotalAmount = totalAmount;
        DiscountAmount = discountAmount;
        PayAmount = payAmount;
        PaymentMethod = paymentMethod;
        IssueTrackingNo = issueTrackingNo;
        IsPaid = false;
        IsCanceled = false;
        RefId = 0;

        Items = new List<OrderItem>();
        Items = items;
    }
    #endregion

    #region Commands
    public void Edit(long accountId, int paymentMethod, double totalAmount, double discountAmount, double payAmount)
    {
        AccountId = accountId;
        TotalAmount = totalAmount;
        DiscountAmount = discountAmount;
        PayAmount = payAmount;
        PaymentMethod = paymentMethod;
    }

    public void PaymentSucceeded(long refId)
    {
        IsPaid = true;

        if (refId != 0)
            RefId = refId;
    }

    public void Cancel() => IsCanceled = true;

    public void SetIssueTrackingNo(string number) => IssueTrackingNo = number;

    public void AddItem(OrderItem item) => Items.Add(item);
    #endregion
}
