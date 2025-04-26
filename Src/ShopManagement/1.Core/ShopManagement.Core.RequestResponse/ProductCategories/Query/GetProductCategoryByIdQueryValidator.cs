using FluentValidation;
using ShopManagement.Core.RequestResponse.ProductCategories.Command.Create;
using Zamin.Extensions.Translations.Abstractions;

namespace ShopManagement.Core.RequestResponse.ProductCategories.Query
{
    public class GetProductCategoryByIdQueryValidator : AbstractValidator<GetProductCategoryByIdQuery>
    {
        public GetProductCategoryByIdQueryValidator(ITranslator translator)
        {
            RuleFor(query => query.ProductCategoryId)
                .NotEmpty()
                .WithMessage(translator["Required", nameof(GetProductCategoryByIdQuery.ProductCategoryId)]);
        }
    }
}
