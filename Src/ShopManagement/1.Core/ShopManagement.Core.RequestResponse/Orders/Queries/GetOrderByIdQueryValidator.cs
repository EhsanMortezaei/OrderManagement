using FluentValidation;
using Zamin.Extensions.Translations.Abstractions;

namespace ShopManagement.Core.RequestResponse.Orders.Queries;

public sealed class GetOrderByIdQueryValidator : AbstractValidator<GetOrderByIdQuery>
{
    public GetOrderByIdQueryValidator(ITranslator translator)
    {
        RuleFor(query => query.OrderId)
            .NotEmpty()
            .WithMessage(translator["Required", nameof(GetOrderByIdQuery.OrderId)]);
    }
}
