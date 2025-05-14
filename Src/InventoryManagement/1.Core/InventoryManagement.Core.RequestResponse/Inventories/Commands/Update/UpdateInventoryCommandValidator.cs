using FluentValidation;
using Framework.ValidationMessages;

namespace InventoryManagement.Core.RequestResponse.Inventories.Commands.Update;

public sealed class UpdateInventoryCommandValidator : AbstractValidator<UpdateInventoryCommand>
{
    public UpdateInventoryCommandValidator()
    {
        RuleFor(x => x.Id)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);

        RuleFor(x => x.ProductId)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);

        RuleFor(x => x.UnitPrice)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.UnitPriceGreaterThanZero);

        RuleFor(x => x.Operations)
            .NotEmpty()
            .WithMessage(ValidationMessages.OperationsRequired);
    }
}
