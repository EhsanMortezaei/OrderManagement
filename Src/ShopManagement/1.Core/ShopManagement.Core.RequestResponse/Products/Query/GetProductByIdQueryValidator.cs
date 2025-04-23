using FluentValidation;
using ShopManagement.Core.RequestResponse.Products.Command.Create;
using Zamin.Extensions.Translations.Abstractions;

namespace ShopManagement.Core.RequestResponse.Products.Query
{
    public class GetProductByIdQueryValidator : AbstractValidator<CreateProductCommand>
    {
        public GetProductByIdQueryValidator(ITranslator translator)
        {
            RuleFor(query => query.Id)
                .NotEmpty()
                .WithMessage(translator["Required", nameof(GetProductByIdQuery.ProductId)]);
        }
    }
}
