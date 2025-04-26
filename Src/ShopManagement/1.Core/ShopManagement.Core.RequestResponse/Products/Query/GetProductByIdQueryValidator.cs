using FluentValidation;
using Zamin.Extensions.Translations.Abstractions;

namespace ShopManagement.Core.RequestResponse.Products.Query
{
    public class GetProductByIdQueryValidator : AbstractValidator<GetProductByIdQuery>
    {
        public GetProductByIdQueryValidator(ITranslator translator)
        {
            RuleFor(query => query.ProductId)
                .NotEmpty()
                .WithMessage(translator["Required", nameof(GetProductByIdQuery.ProductId)]);
        }
    }
}
