using Zamin.Core.Domain.Events;

namespace ShopManagement.Core.Domain.Orders.Events;

public record OrderCreated(Guid BusinessId,
                           long accountId,
                           int paymentMethod,
                           double totalAmount,
                           double discountAmount,
                           double payAmount) : IDomainEvent
{
}
