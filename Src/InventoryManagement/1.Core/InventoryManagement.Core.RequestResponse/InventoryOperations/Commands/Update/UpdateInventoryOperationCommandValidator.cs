using FluentValidation;
using Framework.ValidationMessages;

namespace InventoryManagement.Core.RequestResponse.InventoryOperations.Commands.Update;

public sealed class UpdateInventoryOperationCommandValidator : AbstractValidator<UpdateInventoryOperationCommand>
{
    public UpdateInventoryOperationCommandValidator()
    {
        RuleFor(x => x.Id)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);

        RuleFor(x => x.Operation)
            .NotNull()
            .WithMessage(ValidationMessages.NotNull);

        RuleFor(x => x.Count)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.CountGreaterThanZero);

        RuleFor(x => x.OperatorId)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);

        RuleFor(x => x.OperationDate)
            .NotEmpty()
            .Must(date => date <= DateTime.Now)
            .WithMessage(ValidationMessages.InvalidDate);

        RuleFor(x => x.CurrentCount)
            .GreaterThanOrEqualTo(0)
            .WithMessage(ValidationMessages.CountGreaterThanZero);

        RuleFor(x => x.Description)
            .NotEmpty()
            .WithMessage(ValidationMessages.Required);

        RuleFor(x => x.OrderId)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);

        RuleFor(x => x.InventoryId)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);
    }
}

