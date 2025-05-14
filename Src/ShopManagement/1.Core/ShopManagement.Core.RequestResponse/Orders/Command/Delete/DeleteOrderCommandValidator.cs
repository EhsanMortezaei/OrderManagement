using FluentValidation;
using Framework.ValidationMessages;

namespace ShopManagement.Core.RequestResponse.Orders.Command.Delete;

public sealed class DeleteOrderCommandValidator : AbstractValidator<DeleteOrderCommand>
{
    public DeleteOrderCommandValidator()
    {
        RuleFor(x => x.Id)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);
    }
}

