using ShopManagement.Core.Domain.ProductCategories.Entities;
using ShopManagement.Core.Domain.Products.Event.Product;
using Zamin.Core.Domain.Entities;

namespace ShopManagement.Core.Domain.Products.Entities
{
    public class Product : AggregateRoot<int>
    {
        public string Name { get; private set; }
        public string Code { get; private set; }
        public string ShortDescription { get; private set; }
        public string Descrption { get; private set; }
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        
        //TODO: Hamed Rename to ProductCategoryId
        public long CategoryId { get; private set; }
        
        public string Slug { get; private set; }
        public string Keywords { get; private set; }
        public string MetaDescription { get; private set; }
        //TODO
        //Property ProductCategoryId

        //TODO Delete
        //public ProductCategory Category { get; private set; }

        public Product(string name,
                       string code,
                       string shortDescription,
                       string descrption,
                       string picture,
                       string pictureAlt,
                       string pictureTitle,
                       long categoryId,
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
            CategoryId = categoryId;
            Slug = slug;
            Keywords = keywords;
            MetaDescription = metaDescription;

            AddEvent(new ProductCreated(BusinessId.Value, Name, Code, ShortDescription,
                Descrption, Picture, PictureAlt, PictureTitle,
                CategoryId, Slug, Keywords, MetaDescription));
        }

        public void Edit(string name,
                         string code,
                         string shortDescription,
                         string descrption,
                         string picture,
                         string pictureAlt,
                         string pictureTitle,
                         long categoryId,
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
            CategoryId = categoryId;
            Slug = slug;
            Keywords = keywords;
            MetaDescription = metaDescription;

            AddEvent(new ProductUpdated(BusinessId.Value, Name, Code, ShortDescription,
                Descrption, Picture, PictureAlt, PictureTitle, CategoryId, Slug, Keywords, MetaDescription));
        }
    }
}
