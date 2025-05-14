using FluentValidation;
using Framework.ValidationMessages;

namespace InventoryManagement.Core.RequestResponse.Inventories.Commands.Delet;

public sealed class DeleteInventoryCommandValidator : AbstractValidator<DeleteInventoryCommand>
{
    public DeleteInventoryCommandValidator()
    {
        RuleFor(x => x.Id)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);
    }
}
