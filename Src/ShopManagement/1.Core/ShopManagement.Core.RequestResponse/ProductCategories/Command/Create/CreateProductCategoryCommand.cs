using Zamin.Core.RequestResponse.Commands;

namespace ShopManagement.Core.RequestResponse.ProductCategories.Command.Create;

public sealed class CreateProductCategoryCommand : ICommand<Guid>
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Picture { get; set; } = string.Empty;
    public string PictureAlt { get; set; } = string.Empty;
    public string PictureTitle { get; set; } = string.Empty;
    public string KeyWords { get; set; } = string.Empty;
    public string MetaDescription { get; set; } = string.Empty;
    public string Slug { get; set; } = string.Empty;
}
