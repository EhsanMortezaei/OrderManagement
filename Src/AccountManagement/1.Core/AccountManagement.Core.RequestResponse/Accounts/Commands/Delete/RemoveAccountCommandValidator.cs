using FluentValidation;
using Framework.ValidationMessages;
using Zamin.Extensions.Translations.Abstractions;

namespace AccountManagement.Core.RequestResponse.Accounts.Commands.Delete
{
    public sealed class RemoveAccountCommandValidator : AbstractValidator<DeleteAccountCommand>
    {
        public RemoveAccountCommandValidator(ITranslator translator)
        {
            RuleFor(x => x.Id)
            .GreaterThan(0)
            .WithMessage(translator[ValidationMessages.IdGreaterThanZero]);
        }
    }
}
