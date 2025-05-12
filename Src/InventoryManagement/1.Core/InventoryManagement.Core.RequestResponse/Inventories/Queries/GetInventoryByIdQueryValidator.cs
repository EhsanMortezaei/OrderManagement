
using FluentValidation;
using Zamin.Extensions.Translations.Abstractions;

namespace InventoryManagement.Core.RequestResponse.Inventories.Queries;

public sealed class GetInventoryByIdQueryValidator : AbstractValidator<GetInventoryByIdQuery>
{
    public GetInventoryByIdQueryValidator(ITranslator translator)
    {
        RuleFor(query => query.InventoryId)
            .NotEmpty()
            .WithMessage(translator["Required", nameof(GetInventoryByIdQuery.InventoryId)]);
    }
}
