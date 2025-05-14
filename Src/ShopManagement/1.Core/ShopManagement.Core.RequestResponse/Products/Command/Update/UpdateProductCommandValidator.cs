using FluentValidation;
using Framework.ValidationMessages;
using Zamin.Extensions.Translations.Abstractions;

namespace ShopManagement.Core.RequestResponse.Products.Command.Update;

public sealed class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
{
    public UpdateProductCommandValidator(ITranslator translator)
    {
        RuleFor(x => x.Id)
            .GreaterThan(0)
            .WithMessage(translator[ValidationMessages.IdGreaterThanZero, "Id", "0"]);

        RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage(translator[ValidationMessages.Required, "Name"])
            .MinimumLength(3)
            .WithMessage(translator[ValidationMessages.MinimumLength, "Name", "3"])
            .MaximumLength(100)
            .WithMessage(translator[ValidationMessages.MaximumLength, "Name", "100"]);

        RuleFor(x => x.Code)
            .NotEmpty()
            .WithMessage(translator[ValidationMessages.Required, "Code"])
            .MinimumLength(3)
            .WithMessage(translator[ValidationMessages.MinimumLength, "Code", "3"])
            .MaximumLength(50)
            .WithMessage(translator[ValidationMessages.MaximumLength, "Code", "50"]);

        RuleFor(x => x.ShortDescription)
            .NotEmpty()
            .WithMessage(translator[ValidationMessages.Required, "ShortDescription"])
            .MaximumLength(250)
            .WithMessage(translator[ValidationMessages.MaximumLength, "ShortDescription", "250"]);

        RuleFor(x => x.Descrption)
            .NotEmpty()
            .WithMessage(translator[ValidationMessages.Required, "Descrption"])
            .MaximumLength(1000)
            .WithMessage(translator[ValidationMessages.MaximumLength, "Descrption", "1000"]);

        RuleFor(x => x.Picture)
            .NotEmpty()
            .WithMessage(translator[ValidationMessages.Required, "Picture"]);

        RuleFor(x => x.PictureAlt)
            .NotEmpty()
            .WithMessage(translator[ValidationMessages.Required, "PictureAlt"]);

        RuleFor(x => x.PictureTitle)
            .NotEmpty()
            .WithMessage(translator[ValidationMessages.Required, "PictureTitle"]);

        RuleFor(x => x.CategoryId)
            .GreaterThan(0)
            .WithMessage(translator[ValidationMessages.IdGreaterThanZero, "CategoryId", "0"]);

        RuleFor(x => x.Slug)
            .NotEmpty()
            .WithMessage(translator[ValidationMessages.Required, "Slug"])
            .Matches(@"^[a-z0-9]+(?:-[a-z0-9]+)*$")
            .WithMessage(translator[ValidationMessages.InvalidSlug, "Slug"]);

        RuleFor(x => x.Keywords)
            .NotEmpty()
            .WithMessage(translator[ValidationMessages.Required, "Keywords"]);

        RuleFor(x => x.MetaDescription)
            .NotEmpty()
            .WithMessage(translator[ValidationMessages.Required, "MetaDescription"]);
    }
}
