using Framework.ValidationMessages;
using ShopManagement.Core.Contracts.Products.Command;
using ShopManagement.Core.Domain.Products.Entities;
using ShopManagement.Core.RequestResponse.Products.Command.Create;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace ShopManagement.Core.ApplicationService.Products.Commands.Create;

public sealed class CreateProductCommandHandler(ZaminServices zaminServices,
    IProductCommandRepository productCommandRepository) : CommandHandler<CreateProductCommand, Guid>(zaminServices)
{
    public override async Task<CommandResult<Guid>> Handle(CreateProductCommand command)
    {
        //var entity = await productCommandRepository.GetAsync(command.CategoryId);
        //if (entity is null)
        //{
        //    throw new Exception("id نمیتواند خالی باشد");
        //}

        if (productCommandRepository.Exists(x => x.Name == command.Name))
            throw new InvalidEntityStateException(ValidationMessages.DuplicateRoleName);

        var product = new Product(command.Name,
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
        await productCommandRepository.InsertAsync(product);
        await productCommandRepository.CommitAsync();

        return Ok(product.BusinessId.Value);
    }
}
