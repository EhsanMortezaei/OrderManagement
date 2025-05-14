using FluentValidation;
using Framework.ValidationMessages;
using Zamin.Extensions.Translations.Abstractions;

namespace InventoryManagement.Core.RequestResponse.Inventories.Commands.Create;

public sealed class CreateInventoryCommandValidator : AbstractValidator<CreateInventoryCommand>
{
    public CreateInventoryCommandValidator(ITranslator translator)
    {
        RuleFor(x => x.ProductId)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);

        RuleFor(x => x.UnitPrice)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.PriceGreaterThanZero);

        RuleFor(x => x.Operations)
            .NotNull()
            .WithMessage(ValidationMessages.Required)
            .Must(x => x.Any())
            .WithMessage(ValidationMessages.AtLeastOneItem);
    }
}
