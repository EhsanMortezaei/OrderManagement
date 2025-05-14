using FluentValidation;
using Framework.ValidationMessages;

namespace ShopManagement.Core.RequestResponse.Products.Command.Create;

public sealed class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage(ValidationMessages.Required)
            .MinimumLength(3)
            .WithMessage(string.Format(ValidationMessages.MinimumLength, "Name", 3))
            .MaximumLength(100)
            .WithMessage(string.Format(ValidationMessages.MaximumLength, "Name", 100));

        RuleFor(x => x.Code)
            .NotEmpty()
            .WithMessage(ValidationMessages.Required)
            .MinimumLength(3)
            .WithMessage(string.Format(ValidationMessages.MinimumLength, "Code", 3))
            .MaximumLength(50)
            .WithMessage(string.Format(ValidationMessages.MaximumLength, "Code", 50));

        RuleFor(x => x.ShortDescription)
            .NotEmpty()
            .WithMessage(ValidationMessages.Required)
            .MaximumLength(250)
            .WithMessage(string.Format(ValidationMessages.MaximumLength, "ShortDescription", 250));

        RuleFor(x => x.Descrption)
            .NotEmpty()
            .WithMessage(ValidationMessages.Required)
            .MaximumLength(1000)
            .WithMessage(string.Format(ValidationMessages.MaximumLength, "Descrption", 1000));

        RuleFor(x => x.Picture)
            .NotEmpty()
            .WithMessage(ValidationMessages.Required);

        RuleFor(x => x.PictureAlt)
            .NotEmpty()
            .WithMessage(ValidationMessages.Required);

        RuleFor(x => x.PictureTitle)
            .NotEmpty()
            .WithMessage(ValidationMessages.Required);

        RuleFor(x => x.CategoryId)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);

        RuleFor(x => x.Slug)
            .NotEmpty()
            .WithMessage(ValidationMessages.Required)
            .Matches(@"^[a-z0-9]+(?:-[a-z0-9]+)*$")
            .WithMessage(ValidationMessages.InvalidSlug);

        RuleFor(x => x.Keywords)
            .NotEmpty()
            .WithMessage(ValidationMessages.Required);

        RuleFor(x => x.MetaDescription)
            .NotEmpty()
            .WithMessage(ValidationMessages.Required);
    }
}
