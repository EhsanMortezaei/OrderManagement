using Zamin.Core.RequestResponse.Commands;

namespace ShopManagement.Core.RequestResponse.OrderItems.Commands.Delete;

public sealed class DeleteOrderItemCommand : ICommand
{
    public int Id { get; set; }

}
