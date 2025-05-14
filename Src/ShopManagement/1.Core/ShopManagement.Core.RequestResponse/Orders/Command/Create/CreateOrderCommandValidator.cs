using FluentValidation;
using Framework.ValidationMessages;
using Zamin.Extensions.Translations.Abstractions;

namespace ShopManagement.Core.RequestResponse.Orders.Command.Create;

public sealed class CreateOrderCommandValidator : AbstractValidator<CreateOrderCommand>
{
    public CreateOrderCommandValidator(ITranslator translator)
    {
        RuleFor(x => x.AccountId)
    .GreaterThan(0).WithMessage(ValidationMessages.AccountIdRequired);

        RuleFor(x => x.PaymentMethod)
            .GreaterThan(0).WithMessage(ValidationMessages.PaymentMethodInvalid);

        RuleFor(x => x.TotalAmount)
            .GreaterThanOrEqualTo(0).WithMessage(ValidationMessages.TotalAmountNonNegative);

        RuleFor(x => x.DiscountAmount)
            .GreaterThanOrEqualTo(0).WithMessage(ValidationMessages.DiscountAmountNonNegative);

        RuleFor(x => x.PayAmount)
            .GreaterThanOrEqualTo(0).WithMessage(ValidationMessages.PayAmountNonNegative);

        RuleFor(x => x.IssueTrackingNo)
            .NotEmpty().WithMessage(ValidationMessages.IssueTrackingRequired)
            .MaximumLength(20).WithMessage(ValidationMessages.IssueTrackingMaxLength);

        RuleFor(x => x.RefId)
            .GreaterThanOrEqualTo(0).WithMessage(ValidationMessages.RefIdNonNegative);

        RuleFor(x => x.Items)
            .NotNull().WithMessage(ValidationMessages.OrderItemsRequired)
            .NotEmpty().WithMessage(ValidationMessages.OrderMustHaveItems);


    }
}
