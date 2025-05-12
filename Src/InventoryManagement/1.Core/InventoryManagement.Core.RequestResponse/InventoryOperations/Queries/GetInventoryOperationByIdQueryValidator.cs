using FluentValidation;
using Zamin.Extensions.Translations.Abstractions;

namespace InventoryManagement.Core.RequestResponse.InventoryOperations.Queries;

// tarjome ha eslah shavad 
// file const baraye tarjome ijad shavad
public sealed class GetInventoryOperationByIdQueryValidator : AbstractValidator<GetInventoryOperationByIdQuery>
{
    public GetInventoryOperationByIdQueryValidator(ITranslator translator)
    {
        RuleFor(query => query.InventoryOperationId)
            .NotEmpty()
            .WithMessage(translator["Required", nameof(GetInventoryOperationByIdQuery.InventoryOperationId)]);
    }
}
