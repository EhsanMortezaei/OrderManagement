using FluentValidation;
using ShopManagement.Core.RequestResponse.Orders.Command.Create;
using Zamin.Extensions.Translations.Abstractions;

namespace ShopManagement.Core.RequestResponse.Orders.Queries
{
    public class GetOrderByIdQueryValidator : AbstractValidator<GetOrderByIdQuery>
    {
        public GetOrderByIdQueryValidator(ITranslator translator)
        {
            RuleFor(query => query.OrderId)
                .NotEmpty()
                .WithMessage(translator["Required", nameof(GetOrderByIdQuery.OrderId)]);
        }
    }
}
