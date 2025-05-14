using FluentValidation;
using Framework.ValidationMessages;

namespace InventoryManagement.Core.RequestResponse.Inventories.Commands.IncreaseInventory;

public sealed class IncreaseInventoryCommandValidator : AbstractValidator<IncreaseInventoryCommand>
{
    public IncreaseInventoryCommandValidator()
    {
        RuleFor(x => x.InventoryId)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);

        RuleFor(x => x.Count)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.CountGreaterThanZero);

        RuleFor(x => x.Description)
            .NotEmpty()
            .WithMessage(ValidationMessages.Required);
    }
}

