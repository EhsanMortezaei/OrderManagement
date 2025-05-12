using Zamin.Core.Domain.Events;

namespace ShopManagement.Core.Domain.ProductCategories.Event.ProductCategory;

public record ProductCategoryPostCreated(Guid BusinessId,
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
