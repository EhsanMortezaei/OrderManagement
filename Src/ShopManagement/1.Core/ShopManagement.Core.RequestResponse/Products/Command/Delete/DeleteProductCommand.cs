using Zamin.Core.RequestResponse.Commands;

namespace ShopManagement.Core.RequestResponse.Products.Command.Delete;

public sealed class DeleteProductCommand : ICommand
{
    public int Id { get; set; }
}
