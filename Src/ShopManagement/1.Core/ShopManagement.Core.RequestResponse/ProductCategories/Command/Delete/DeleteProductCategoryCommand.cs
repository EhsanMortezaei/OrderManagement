using Zamin.Core.RequestResponse.Commands;

namespace ShopManagement.Core.RequestResponse.ProductCategories.Command.Delete;

public sealed class DeleteProductCategoryCommand : ICommand
{
    public int Id { get; set; }
}
