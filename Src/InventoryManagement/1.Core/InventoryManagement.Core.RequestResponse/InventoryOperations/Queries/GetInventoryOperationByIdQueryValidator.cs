using FluentValidation;
using InventoryManagement.Core.RequestResponse.Inventories.Queries;
using Zamin.Extensions.Translations.Abstractions;

namespace InventoryManagement.Core.RequestResponse.InventoryOperations.Queries
{
    public class GetInventoryOperationByIdQueryValidator : AbstractValidator<GetInventoryOperationByIdQuery>
    {
        public GetInventoryOperationByIdQueryValidator(ITranslator translator)
        {
            RuleFor(query => query.InventoryOperationId)
                .NotEmpty()
                .WithMessage(translator["Required", nameof(GetInventoryOperationByIdQuery.InventoryOperationId)]);
        }
    }
}
