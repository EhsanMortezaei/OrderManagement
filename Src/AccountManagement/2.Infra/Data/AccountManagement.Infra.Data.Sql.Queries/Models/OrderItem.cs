using System;
using System.Collections.Generic;

namespace AccountManagement.Infra.Data.Sql.Queries.Models;

public partial class OrderItem
{
    public int Id { get; set; }

    public long ProductId { get; set; }

    public int Count { get; set; }

    public double UnitPrice { get; set; }

    public int DiscountRate { get; set; }

    public long OrderId { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? ModifiedDateTime { get; set; }

    public int? OrderId1 { get; set; }

    public Guid BusinessId { get; set; }

    public virtual Order? OrderId1Navigation { get; set; }
}
