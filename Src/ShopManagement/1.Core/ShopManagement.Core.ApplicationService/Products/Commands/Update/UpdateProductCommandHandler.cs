using Framework.Enums.Validation;
using Framework.FileUpload;
using Framework.ValidationMessages;
using ShopManagement.Core.Contracts.Products.Command;
using ShopManagement.Core.RequestResponse.Products.Command.Update;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace ShopManagement.Core.ApplicationService.Products.Commands.Update;

public sealed class UpdateProductCommandHandler(ZaminServices zaminServices,
    IProductCommandRepository productCommandRepository,
    IFileUploader fileUploader) : CommandHandler<UpdateProductCommand>(zaminServices)
{
    public override async Task<CommandResult> Handle(UpdateProductCommand command)
    {
        if (productCommandRepository.Exists(c => c.Id == command.Id))
            throw new InvalidEntityStateException(ValidationMessages.DuplicateRoleName);

        var product = await productCommandRepository.GetAsync(command.Id)
            ?? throw new InvalidEntityStateException(ErrorMessages.Get(ErrorMessageKey.ProductError));

        var path = $"profilePhotos";
        var picture = fileUploader.Upload(command.Picture, path);

        product.Edit(command.Name,
                     command.Code,
                     command.ShortDescription,
                     command.Descrption,
                     picture,
                     command.PictureAlt,
                     command.PictureTitle,
                     command.CategoryId,
                     command.Slug,
                     command.Keywords,
                     command.MetaDescription);

        await productCommandRepository.CommitAsync();

        return Ok();
    }
}
