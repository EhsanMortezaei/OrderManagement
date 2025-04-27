using Zamin.Core.Domain.Events;

namespace ShopManagement.Core.Domain.ProductCategories.Event.ProductCategory
{
    public record ProductCategoryCreated(Guid BusinessId,
                                         string name,
                                         string description,
                                         string picture,
                                         string pictureAlt,
                                         string pictureTitle,
                                         string keyWords,
                                         string metaDescription,
                                         string slug) : IDomainEvent;
}
