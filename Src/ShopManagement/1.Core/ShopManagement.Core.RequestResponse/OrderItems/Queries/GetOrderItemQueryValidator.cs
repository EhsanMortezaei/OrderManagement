using FluentValidation;
using ShopManagement.Core.RequestResponse.OrderItems.Command.Create;
using Zamin.Extensions.Translations.Abstractions;

namespace ShopManagement.Core.RequestResponse.OrderItems.Queries
{
    public class GetOrderItemQueryValidator: AbstractValidator<CreateOrderItemCommand>
    {
        public GetOrderItemQueryValidator(ITranslator translator)
        {
            RuleFor(query => query.Id)
                .NotEmpty()
                .WithMessage(translator["Required", nameof(GetOrderItemByIdQuery.Id)]);
        }
    }
}
