using Zamin.Core.RequestResponse.Commands;

namespace ShopManagement.Core.RequestResponse.Products.Command.Update;

public sealed class UpdateProductCommand : ICommand
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public string ShortDescription { get; set; } = string.Empty;
    public string Descrption { get; set; } = string.Empty;
    public string Picture { get; set; } = string.Empty;
    public string PictureAlt { get; set; } = string.Empty;
    public string PictureTitle { get; set; } = string.Empty;
    public int CategoryId { get; set; }
    public string Slug { get; set; } = string.Empty;
    public string Keywords { get; set; } = string.Empty;
    public string MetaDescription { get; set; } = string.Empty;
}
