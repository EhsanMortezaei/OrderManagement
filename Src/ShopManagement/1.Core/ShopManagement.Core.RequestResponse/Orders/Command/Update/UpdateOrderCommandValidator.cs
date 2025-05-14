using FluentValidation;
using Framework.ValidationMessages;

namespace ShopManagement.Core.RequestResponse.Orders.Command.Update;

public sealed class UpdateOrderCommandValidator : AbstractValidator<UpdateOrderCommand>
{
    public UpdateOrderCommandValidator()
    {
        RuleFor(x => x.Id)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);

        RuleFor(x => x.AccountId)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);

        RuleFor(x => x.PaymentMethod)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.InvalidPaymentMethod);

        RuleFor(x => x.TotalAmount)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.AmountGreaterThanZero);

        RuleFor(x => x.DiscountAmount)
            .GreaterThanOrEqualTo(0)
            .WithMessage(ValidationMessages.AmountGreaterThanZero);

        RuleFor(x => x.PayAmount)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.AmountGreaterThanZero);

        RuleFor(x => x.IssueTrackingNo)
            .NotEmpty()
            .WithMessage(ValidationMessages.Required);
    }
}

