using Zamin.Core.Domain.Events;

namespace ShopManagement.Core.Domain.Products.Event.Product;

public record ProductUpdated(Guid BusinessId,
                             string name,
                             string code,
                             string shortDescription,
                             string descrption,
                             string picture,
                             string pictureAlt,
                             string pictureTitle,
                             long categoryId,
                             string slug,
                             string keywords,
                             string metaDescription) : IDomainEvent;
