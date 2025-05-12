using FluentValidation;
using Zamin.Extensions.Translations.Abstractions;

namespace InventoryManagement.Core.RequestResponse.InventoryOperations.Commands.Create;

public sealed class CreateInventoryOperationCommandValidator : AbstractValidator<CreateInventoryOperationCommand>
{
    public CreateInventoryOperationCommandValidator(ITranslator translator)
    {
    }
}
