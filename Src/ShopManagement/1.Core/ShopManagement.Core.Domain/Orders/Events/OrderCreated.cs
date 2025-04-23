using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zamin.Core.Domain.Events;

namespace ShopManagement.Core.Domain.Orders.Events
{
    public record OrderCreated(Guid BusinessId,
                               long accountId,
                               int paymentMethod,
                               double totalAmount,
                               double discountAmount,
                               double payAmount) : IDomainEvent
    {
    }
}
