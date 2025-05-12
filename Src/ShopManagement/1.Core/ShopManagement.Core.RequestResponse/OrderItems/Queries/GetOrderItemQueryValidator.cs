using FluentValidation;
using Zamin.Extensions.Translations.Abstractions;

namespace ShopManagement.Core.RequestResponse.OrderItems.Queries;

public sealed class GetOrderItemQueryValidator : AbstractValidator<GetOrderItemByIdQuery>
{
    public GetOrderItemQueryValidator(ITranslator translator)
    {
        RuleFor(query => query.Id)
            .NotEmpty()
            .WithMessage(translator["Required", nameof(GetOrderItemByIdQuery.Id)]);
    }
}
