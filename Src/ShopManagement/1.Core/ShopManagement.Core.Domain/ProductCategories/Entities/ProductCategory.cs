using Zamin.Core.Domain.Entities;

namespace ShopManagement.Core.Domain.ProductCategories.Entities;

public sealed class ProductCategory : AggregateRoot<int>
{
    public string Name { get; private set; } = null!;
    public string Description { get; private set; } = null!;
    public string Picture { get; private set; } = string.Empty;
    public string PictureAlt { get; private set; } = string.Empty;
    public string PictureTitle { get; private set; } = string.Empty;
    public string KeyWords { get; private set; } = string.Empty;
    public string MetaDescription { get; private set; } = string.Empty;
    public string Slug { get; private set; } = string.Empty;

    ProductCategory() { }

    public ProductCategory(string name,
                           string description,
                           string picture,
                           string pictureAlt,
                           string pictureTitle,
                           string keyWords,
                           string metaDescription,
                           string slug)
    {
        Name = name;
        Description = description;
        Picture = picture;
        PictureAlt = pictureAlt;
        PictureTitle = pictureTitle;
        KeyWords = keyWords;
        MetaDescription = metaDescription;
        Slug = slug;
    }

    public void Edit(string name,
                     string description,
                     string picture,
                     string pictureAlt,
                     string pictureTitle,
                     string keyWords,
                     string metaDescription,
                     string slug)
    {
        Name = name;
        Description = description;
        if (!string.IsNullOrWhiteSpace(picture))
        {
            Picture = picture;
        }
        PictureAlt = pictureAlt;
        PictureTitle = pictureTitle;
        KeyWords = keyWords;
        MetaDescription = metaDescription;
        Slug = slug;
    }
}
