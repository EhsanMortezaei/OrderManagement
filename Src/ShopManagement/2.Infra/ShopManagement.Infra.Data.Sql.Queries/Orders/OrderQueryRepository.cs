﻿using Microsoft.EntityFrameworkCore;
using ShopManagement.Core.Contracts.Orders.Queries;
using ShopManagement.Core.RequestResponse.Orders.Queries;
using ShopManagement.Infra.Data.Sql.Queries.Common;
using Zamin.Infra.Data.Sql.Queries;


namespace ShopManagement.Infra.Data.Sql.Queries.Orders;

public sealed class OrderQueryRepository : BaseQueryRepository<ShopManagementQueryDbContext>, IOrderQueryRepository
{
    public OrderQueryRepository(ShopManagementQueryDbContext dbContext) : base(dbContext)
    {
    }
    public async Task<OrderQr?> ExecuteAsync(GetOrderByIdQuery query)
    => await _dbContext.Orders.Select(c => new OrderQr()
    {
        Id = c.Id,
        AccountId = c.AccountId,
        PaymentMethod = c.PaymentMethod,
        TotalAmount = c.TotalAmount,
        PayAmount = c.PayAmount,
        IsPaid = c.IsPaid,
        IsCanceled = c.IsCanceled,
        IssueTrackingNo = c.IssueTrackingNo,
        RefId = c.RefId,

    }).FirstOrDefaultAsync(c => c.Id.Equals(query.OrderId));
}
