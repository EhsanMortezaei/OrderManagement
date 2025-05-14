using FluentValidation;
using Framework.ValidationMessages;

namespace ShopManagement.Core.RequestResponse.ProductCategories.Command.Update;

public sealed class UpdateProductCategoryCommandValidator : AbstractValidator<UpdateProductCategoryCommand>
{
    public UpdateProductCategoryCommandValidator()
    {
        RuleFor(x => x.Id)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);

        RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage(ValidationMessages.Required)
            .MinimumLength(3)
            .WithMessage(string.Format(ValidationMessages.MinimumLength, "Name", 3))
            .MaximumLength(100)
            .WithMessage(string.Format(ValidationMessages.MaximumLength, "Name", 100));

        RuleFor(x => x.Description)
            .NotEmpty()
            .WithMessage(ValidationMessages.Required)
            .MaximumLength(500)
            .WithMessage(string.Format(ValidationMessages.MaximumLength, "Description", 500));

        RuleFor(x => x.Picture)
            .NotEmpty()
            .WithMessage(ValidationMessages.Required);

        RuleFor(x => x.PictureAlt)
            .NotEmpty()
            .WithMessage(ValidationMessages.Required);

        RuleFor(x => x.PictureTitle)
            .NotEmpty()
            .WithMessage(ValidationMessages.Required);

        RuleFor(x => x.KeyWords)
            .NotEmpty()
            .WithMessage(ValidationMessages.Required);

        RuleFor(x => x.MetaDescription)
            .NotEmpty()
            .WithMessage(ValidationMessages.Required);

        RuleFor(x => x.Slug)
            .NotEmpty()
            .WithMessage(ValidationMessages.Required)
            .Matches(@"^[a-z0-9]+(?:-[a-z0-9]+)*$")
            .WithMessage(ValidationMessages.InvalidSlug);
    }
}
