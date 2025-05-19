using Framework.ErrorMessages;
using Framework.FileUpload;
using ShopManagement.Core.Contracts.ProductCategories.Command;
using ShopManagement.Core.Domain.ProductCategories.Entities;
using ShopManagement.Core.RequestResponse.ProductCategories.Command.Create;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace ShopManagement.Core.ApplicationService.ProductCategories.Command.Create;

public sealed class CreateProductCategoryCommandHandler(ZaminServices zaminServices,
    IProductCategoryCommandRepository productCategoryCommandRepository,
    IFileUploader fileUploader) : CommandHandler<CreateProductCategoryCommand, Guid>(zaminServices)
{
    public override async Task<CommandResult<Guid>> Handle(CreateProductCategoryCommand command)
    {
        if (productCategoryCommandRepository.Exists(c => c.Name == command.Name))
            throw new InvalidEntityStateException(ErrorMessage.UsernameAlreadyExists);

        var path = $"profilePhotos";
        var picture = fileUploader.Upload(command.Picture, path);

        var productCategory = new ProductCategory(command.Name,
                                                  command.Description,
                                                  picture,
                                                  command.PictureAlt,
                                                  command.PictureTitle,
                                                  command.KeyWords,
                                                  command.MetaDescription,
                                                  command.Slug);

        await productCategoryCommandRepository.InsertAsync(productCategory);
        await productCategoryCommandRepository.CommitAsync();

        return Ok(productCategory.BusinessId.Value);
    }
}
