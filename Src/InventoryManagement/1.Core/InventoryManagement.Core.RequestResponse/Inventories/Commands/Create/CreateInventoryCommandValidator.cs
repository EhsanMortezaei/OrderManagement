using FluentValidation;
using Zamin.Extensions.Translations.Abstractions;

namespace InventoryManagement.Core.RequestResponse.Inventories.Commands.Create
{
    public class CreateInventoryCommandValidator : AbstractValidator<CreateInventoryCommand>
    {
        public CreateInventoryCommandValidator(ITranslator translator)
        {
        }
    }
}
