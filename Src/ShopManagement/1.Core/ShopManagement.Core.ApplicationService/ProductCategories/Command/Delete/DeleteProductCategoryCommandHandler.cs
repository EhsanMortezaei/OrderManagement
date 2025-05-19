using Framework.ErrorMessages;
using ShopManagement.Core.Contracts.ProductCategories.Command;
using ShopManagement.Core.RequestResponse.ProductCategories.Command.Delete;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace ShopManagement.Core.ApplicationService.ProductCategories.Command.Delete;

public sealed class DeleteProductCategoryCommandHandler(ZaminServices zaminServices,
                                           IProductCategoryCommandRepository productCategoryCommandRepository) : CommandHandler<DeleteProductCategoryCommand>(zaminServices)
{
    public override async Task<CommandResult> Handle(DeleteProductCategoryCommand command)
    {
        var productCategory = await productCategoryCommandRepository.GetGraphAsync(command.Id)
            ?? throw new InvalidEntityStateException(ErrorMessage.ProductCategoryError);

        productCategoryCommandRepository.Delete(productCategory);

        await productCategoryCommandRepository.CommitAsync();

        return Ok();
    }
}
