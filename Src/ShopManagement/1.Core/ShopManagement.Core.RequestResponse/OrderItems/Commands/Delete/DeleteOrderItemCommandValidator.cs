using FluentValidation;
using Framework.ValidationMessages;

namespace ShopManagement.Core.RequestResponse.OrderItems.Commands.Delete;

public sealed class DeleteOrderItemCommandValidator : AbstractValidator<DeleteOrderItemCommand>
{
    public DeleteOrderItemCommandValidator()
    {
        RuleFor(x => x.Id)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);
    }
}

