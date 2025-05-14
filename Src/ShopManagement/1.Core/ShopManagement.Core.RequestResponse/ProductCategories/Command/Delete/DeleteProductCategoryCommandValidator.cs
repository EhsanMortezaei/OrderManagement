using FluentValidation;
using Framework.ValidationMessages;

namespace ShopManagement.Core.RequestResponse.ProductCategories.Command.Delete;

public sealed class DeleteProductCategoryCommandValidator : AbstractValidator<DeleteProductCategoryCommand>
{
    public DeleteProductCategoryCommandValidator()
    {
        RuleFor(x => x.Id)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);
    }
}
