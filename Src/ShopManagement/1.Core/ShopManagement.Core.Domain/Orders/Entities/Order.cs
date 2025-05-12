using ShopManagement.Core.Domain.Orders.Events;
using Zamin.Core.Domain.Entities;

namespace ShopManagement.Core.Domain.Orders.Entities;

public sealed class Order : AggregateRoot<int>
{
    public long AccountId { get;  set; }
    public int PaymentMethod { get;  set; }
    public double TotalAmount { get;  set; }
    public double DiscountAmount { get;  set; }
    public double PayAmount { get;  set; }
    public bool IsPaid { get;  set; }
    public bool IsCanceled { get;  set; }
    public string IssueTrackingNo { get;  set; } = string.Empty;
    public long RefId { get;  set; }
    public List<OrderItem> Items { get;  set; } = new List<OrderItem>();

     Order() { }

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

        // pak shavad
        AddEvent(new OrderCreated(BusinessId.Value,
                                  AccountId,
                                  PaymentMethod,
                                  TotalAmount,
                                  DiscountAmount,
                                  PayAmount));
    }

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

    public void Cancel()
    {
        IsCanceled = true;
    }

    public void SetIssueTrackingNo(string number)
    {
        IssueTrackingNo = number;
    }

    public void AddItem(OrderItem item)
    {
        Items.Add(item);
    }
}
