using Zamin.Core.Domain.Events;

namespace ShopManagement.Core.Domain.Orders.Events
{
    public record OrderItemCreated(Guid BusinessId, long productId,
        int count, double unitPrice,
        int discountRate) : IDomainEvent;
}
