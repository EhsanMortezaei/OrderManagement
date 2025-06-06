﻿using Framework.Enums.Validation;
using ShopManagement.Core.Contracts.ProductCategories.Command;
using ShopManagement.Core.RequestResponse.ProductCategories.Command.Update;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace ShopManagement.Core.ApplicationService.ProductCategories.Command.Update;

public sealed class UpdateProductCategoryCommandHandler(ZaminServices zaminServices,
                                           IProductCategoryCommandRepository productCategoryCommandRepository) : CommandHandler<UpdateProductCategoryCommand>(zaminServices)
{
    public override async Task<CommandResult> Handle(UpdateProductCategoryCommand command)
    {
        var productCategory = await productCategoryCommandRepository.GetAsync(command.Id);
        if (productCategory is null)
            throw new InvalidEntityStateException(ErrorMessages.Get(ErrorMessageKey.ProductCategoryError));
        productCategory.Edit(command.Name,
                             command.Description,
                             command.Picture,
                             command.PictureAlt,
                             command.PictureTitle,
                             command.KeyWords,
                             command.MetaDescription,
                             command.Slug);

        await productCategoryCommandRepository.CommitAsync();

        return Ok();
    }
}
