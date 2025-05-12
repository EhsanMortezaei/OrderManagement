using Zamin.Core.RequestResponse.Commands;

namespace ShopManagement.Core.RequestResponse.Orders.Command.Delete;

public sealed class DeleteOrderCommand : ICommand
{
    public int Id { get; set; }
}
