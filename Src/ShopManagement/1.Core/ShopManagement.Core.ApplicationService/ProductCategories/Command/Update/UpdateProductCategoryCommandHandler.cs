using Framework.ErrorMessages;
using Framework.FileUpload;
using ShopManagement.Core.Contracts.ProductCategories.Command;
using ShopManagement.Core.RequestResponse.ProductCategories.Command.Update;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace ShopManagement.Core.ApplicationService.ProductCategories.Command.Update;

public sealed class UpdateProductCategoryCommandHandler(ZaminServices zaminServices,
                                           IProductCategoryCommandRepository productCategoryCommandRepository,
                                           IFileUploader fileUploader) : CommandHandler<UpdateProductCategoryCommand>(zaminServices)
{
    public override async Task<CommandResult> Handle(UpdateProductCategoryCommand command)
    {
        if (productCategoryCommandRepository.Exists(x => x.Name == command.Name))
            throw new InvalidEntityStateException(ErrorMessage.DuplicateRoleName);

        var path = $"profilePhotos";
        var picture = fileUploader.Upload(command.Picture, path);

        var productCategory = await productCategoryCommandRepository.GetAsync(command.Id)
            ?? throw new InvalidEntityStateException(ErrorMessage.ProductCategoryError);
        productCategory.Edit(command.Name,
                             command.Description,
                             picture,
                             command.PictureAlt,
                             command.PictureTitle,
                             command.KeyWords,
                             command.MetaDescription,
                             command.Slug);

        await productCategoryCommandRepository.CommitAsync();

        return Ok();
    }
}
