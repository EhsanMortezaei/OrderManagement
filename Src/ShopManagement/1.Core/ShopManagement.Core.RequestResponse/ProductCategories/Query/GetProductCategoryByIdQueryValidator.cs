using FluentValidation;
using ShopManagement.Core.RequestResponse.ProductCategories.Command.Create;
using Zamin.Extensions.Translations.Abstractions;

namespace ShopManagement.Core.RequestResponse.ProductCategories.Query
{
    public class GetProductCategoryByIdQueryValidator : AbstractValidator<CreateProductCategoryCommand>
    {
        public GetProductCategoryByIdQueryValidator(ITranslator translator)
        {
            RuleFor(query => query.Id)
                .NotEmpty()
                .WithMessage(translator["Required", nameof(GetProductCategoryByIdQuery.ProductCategoryId)]);
        }
    }
}
