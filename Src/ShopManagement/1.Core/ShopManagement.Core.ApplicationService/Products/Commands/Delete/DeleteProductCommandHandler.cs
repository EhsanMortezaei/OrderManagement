using Framework.Enums.Validation;
using ShopManagement.Core.Contracts.Products.Command;
using ShopManagement.Core.RequestResponse.Products.Command.Delete;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace ShopManagement.Core.ApplicationService.Products.Commands.Delete;

public sealed class DeleteProductCommandHandler(ZaminServices zaminServices,
                                  IProductCommandRepository productCommandRepository) : CommandHandler<DeleteProductCommand>(zaminServices)
{
    public override async Task<CommandResult> Handle(DeleteProductCommand command)
    {
        var product = await productCommandRepository.GetGraphAsync(command.Id)
            ?? throw new InvalidEntityStateException(ErrorMessages.Get(ErrorMessageKey.ProductError));

        productCommandRepository.Delete(product);

        await productCommandRepository.CommitAsync();

        return Ok();
    }
}
