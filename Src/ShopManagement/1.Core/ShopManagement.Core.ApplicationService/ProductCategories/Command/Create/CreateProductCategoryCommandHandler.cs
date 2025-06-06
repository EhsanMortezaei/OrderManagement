﻿using ShopManagement.Core.Contracts.ProductCategories.Command;
using ShopManagement.Core.Domain.ProductCategories.Entities;
using ShopManagement.Core.RequestResponse.ProductCategories.Command.Create;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace ShopManagement.Core.ApplicationService.ProductCategories.Command.Create;

public sealed class CreateProductCategoryCommandHandler(ZaminServices zaminServices,
    IProductCategoryCommandRepository productCategoryCommandRepository) : CommandHandler<CreateProductCategoryCommand, Guid>(zaminServices)
{
    public override async Task<CommandResult<Guid>> Handle(CreateProductCategoryCommand command)
    {
        var productCategory = new ProductCategory(command.Name,
                                                  command.Description,
                                                  command.Picture,
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
