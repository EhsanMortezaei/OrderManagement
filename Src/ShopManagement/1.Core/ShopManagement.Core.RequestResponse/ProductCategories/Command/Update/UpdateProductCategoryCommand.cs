using Microsoft.AspNetCore.Http;
using Zamin.Core.RequestResponse.Commands;

namespace ShopManagement.Core.RequestResponse.ProductCategories.Command.Update;

public sealed class UpdateProductCategoryCommand : ICommand
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public IFormFile Picture { get; set; } = null!;
    public string PictureAlt { get; set; } = string.Empty;
    public string PictureTitle { get; set; } = string.Empty;
    public string KeyWords { get; set; } = string.Empty;
    public string MetaDescription { get; set; } = string.Empty;
    public string Slug { get; set; } = string.Empty;
}
