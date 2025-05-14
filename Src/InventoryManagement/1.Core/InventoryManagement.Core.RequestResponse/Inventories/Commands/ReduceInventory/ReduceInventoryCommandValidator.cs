using FluentValidation;
using Framework.ValidationMessages;

namespace InventoryManagement.Core.RequestResponse.Inventories.Commands.ReduceInventory;

public sealed class ReduceInventoryCommandValidator : AbstractValidator<ReduceInventoryCommand>
{
    public ReduceInventoryCommandValidator()
    {
        RuleFor(x => x.InventoryId)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);

        RuleFor(x => x.ProductId)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);
    }
}

