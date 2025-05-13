using Framework.Enums.Validation;
using ShopManagement.Core.Contracts.ProductCategories.Command;
using ShopManagement.Core.RequestResponse.ProductCategories.Command.Delete;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace ShopManagement.Core.ApplicationService.ProductCategories.Command.Delete;

public sealed class DeleteProductCategoryCommandHandler : CommandHandler<DeleteProductCategoryCommand>
{
    readonly IProductCategoryCommandRepository _productCategoryCommandRepository;

    public DeleteProductCategoryCommandHandler(ZaminServices zaminServices,
                                               IProductCategoryCommandRepository productCategoryCommandRepository) : base(zaminServices)
    {
        _productCategoryCommandRepository = productCategoryCommandRepository;
    }


    public override async Task<CommandResult> Handle(DeleteProductCategoryCommand command)
    {
        var productCategory = await _productCategoryCommandRepository.GetGraphAsync(command.Id)
            ?? throw new InvalidEntityStateException(ErrorMessages.Get(ErrorMessageKey.ProductCategoryError));

        _productCategoryCommandRepository.Delete(productCategory);

        await _productCategoryCommandRepository.CommitAsync();

        return Ok();
    }
}
