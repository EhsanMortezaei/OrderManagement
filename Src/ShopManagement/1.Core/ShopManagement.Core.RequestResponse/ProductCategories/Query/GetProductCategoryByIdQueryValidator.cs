using FluentValidation;
using Zamin.Extensions.Translations.Abstractions;

namespace ShopManagement.Core.RequestResponse.ProductCategories.Query;

public sealed class GetProductCategoryByIdQueryValidator : AbstractValidator<GetProductCategoryByIdQuery>
{
    public GetProductCategoryByIdQueryValidator(ITranslator translator)
    {
        RuleFor(query => query.ProductCategoryId)
            .NotEmpty()
            .WithMessage(translator["Required", nameof(GetProductCategoryByIdQuery.ProductCategoryId)]);
    }
}
