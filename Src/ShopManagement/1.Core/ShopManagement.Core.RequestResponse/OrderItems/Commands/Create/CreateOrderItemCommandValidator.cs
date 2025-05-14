using FluentValidation;
using Framework.ValidationMessages;

namespace ShopManagement.Core.RequestResponse.OrderItems.Commands.Create;

public sealed class CreateOrderItemCommandValidator : AbstractValidator<CreateOrderItemCommand>
{
    public CreateOrderItemCommandValidator()
    {
        RuleFor(x => x.Id)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);

        RuleFor(x => x.ProductId)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);

        RuleFor(x => x.Count)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.CountGreaterThanZero);

        RuleFor(x => x.UnitPrice)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.PriceGreaterThanZero);

        RuleFor(x => x.DiscountRate)
            .InclusiveBetween(0, 100)
            .WithMessage(ValidationMessages.DiscountRateValid);

        RuleFor(x => x.OrderId)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);
    }
}
