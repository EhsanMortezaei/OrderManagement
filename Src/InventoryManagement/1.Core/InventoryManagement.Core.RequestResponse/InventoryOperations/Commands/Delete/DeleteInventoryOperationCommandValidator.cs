using FluentValidation;
using Framework.ValidationMessages;

namespace InventoryManagement.Core.RequestResponse.InventoryOperations.Commands.Delete;

public sealed class DeleteInventoryOperationCommandValidator : AbstractValidator<DeleteInventoryOperationCommand>
{
    public DeleteInventoryOperationCommandValidator()
    {
        RuleFor(x => x.Id)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);
    }
}

