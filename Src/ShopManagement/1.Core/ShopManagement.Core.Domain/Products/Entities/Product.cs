using ShopManagement.Core.Domain.Products.Event.Product;
using Zamin.Core.Domain.Entities;

namespace ShopManagement.Core.Domain.Products.Entities;

public sealed class Product : AggregateRoot<int>
{
    public string Name { get;  set; } = null!;
    public string Code { get;  set; } = null!;
    public string ShortDescription { get;  set; } = null!;
    public string Descrption { get;  set; } = null!;
    public string Picture { get;  set; } = null!;
    public string PictureAlt { get;  set; } = null!;
    public string PictureTitle { get;  set; } = null!;

    public int ProductCategoryId { get;  set; }

    public string Slug { get;  set; } = null!;
    public string Keywords { get;  set; } = null!;
    public string MetaDescription { get;  set; } = null!;

     Product() { }

    public Product(string name,
                   string code,
                   string shortDescription,
                   string descrption,
                   string picture,
                   string pictureAlt,
                   string pictureTitle,
                   int categoryId,
                   string slug,
                   string keywords,
                   string metaDescription)
    {
        Name = name;
        Code = code;
        ShortDescription = shortDescription;
        Descrption = descrption;
        Picture = picture;
        PictureAlt = pictureAlt;
        PictureTitle = pictureTitle;
        ProductCategoryId = categoryId;
        Slug = slug;
        Keywords = keywords;
        MetaDescription = metaDescription;

        AddEvent(new ProductCreated(BusinessId.Value, Name, Code, ShortDescription,
            Descrption, Picture, PictureAlt, PictureTitle,
            ProductCategoryId, Slug, Keywords, MetaDescription));
    }

    public void Edit(string name,
                     string code,
                     string shortDescription,
                     string descrption,
                     string picture,
                     string pictureAlt,
                     string pictureTitle,
                     int categoryId,
                     string slug,
                     string keywords,
                     string metaDescription)
    {
        Name = name;
        Code = code;
        ShortDescription = shortDescription;
        Descrption = descrption;
        if (!string.IsNullOrEmpty(picture))
        {
            Picture = picture;
        }
        PictureAlt = pictureAlt;
        PictureTitle = pictureTitle;
        ProductCategoryId = categoryId;
        Slug = slug;
        Keywords = keywords;
        MetaDescription = metaDescription;

        AddEvent(new ProductUpdated(BusinessId.Value, Name, Code, ShortDescription,
            Descrption, Picture, PictureAlt, PictureTitle, ProductCategoryId, Slug, Keywords, MetaDescription));
    }
}
