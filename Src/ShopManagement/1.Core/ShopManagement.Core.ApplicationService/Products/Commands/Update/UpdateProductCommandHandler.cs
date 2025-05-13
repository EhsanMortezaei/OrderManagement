using Framework.Enums.Validation;
using ShopManagement.Core.Contracts.Products.Command;
using ShopManagement.Core.RequestResponse.Products.Command.Update;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace ShopManagement.Core.ApplicationService.Products.Commands.Update;

public sealed class UpdateProductCommandHandler : CommandHandler<UpdateProductCommand>
{
    readonly IProductCommandRepository _productCommandRepository;

    public UpdateProductCommandHandler(ZaminServices zaminServices,
        IProductCommandRepository productCommandRepository) : base(zaminServices)
    {
        _productCommandRepository = productCommandRepository;
    }

    public override async Task<CommandResult> Handle(UpdateProductCommand command)
    {
        var product = await _productCommandRepository.GetAsync(command.Id);
        if (product is null)
            throw new InvalidEntityStateException(ErrorMessages.Get(ErrorMessageKey.ProductError));
        product.Edit(command.Name,
                     command.Code,
                     command.ShortDescription,
                     command.Descrption,
                     command.Picture,
                     command.PictureAlt,
                     command.PictureTitle,
                     command.CategoryId,
                     command.Slug,
                     command.Keywords,
                     command.MetaDescription);

        await _productCommandRepository.CommitAsync();

        return Ok();
    }
}
