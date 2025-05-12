namespace AccountManagement.Infra.Data.Sql.Queries.Models;

public partial class Order
{
    public int Id { get; set; }

    public long AccountId { get; set; }

    public int PaymentMethod { get; set; }

    public double TotalAmount { get; set; }

    public double DiscountAmount { get; set; }

    public double PayAmount { get; set; }

    public bool IsPaid { get; set; }

    public bool IsCanceled { get; set; }

    public string IssueTrackingNo { get; set; } = null!;

    public long RefId { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? ModifiedDateTime { get; set; }

    public Guid BusinessId { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
