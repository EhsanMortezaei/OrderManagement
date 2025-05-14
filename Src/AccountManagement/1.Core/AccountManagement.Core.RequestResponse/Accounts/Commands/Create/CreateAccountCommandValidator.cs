using FluentValidation;
using Framework.Enums.Validation;
using Framework.ValidationMessages;
using Zamin.Extensions.Translations.Abstractions;

namespace AccountManagement.Core.RequestResponse.Accounts.Commands.Create;

// tarjome ha eslah shavad 
// file const baraye tarjome ijad shavad
public sealed class CreateAccountCommandValidator : AbstractValidator<CreateAccountCommand>
{
    public CreateAccountCommandValidator(ITranslator translator)
    {
        RuleFor(c => c.Username)
            .NotNull().WithMessage(translator[ValidationMessages.Required, "Username"])
            .MinimumLength(2).WithMessage(translator[ValidationMessages.MinimumLength, "Username", "2"])
            .MaximumLength(100).WithMessage(translator[ValidationMessages.MaximumLength, "Username", "100"]);


        RuleFor(c => c.Fullname)
            .NotNull().WithMessage(translator[ValidationMessages.Required, "Fullname"])
            .MinimumLength(5).WithMessage(translator[ValidationMessages.Required, "Fullname", "5"])
            .MaximumLength(30).WithMessage(translator[ValidationMessages.Required, "Fullname", "30"]);
    }
}
