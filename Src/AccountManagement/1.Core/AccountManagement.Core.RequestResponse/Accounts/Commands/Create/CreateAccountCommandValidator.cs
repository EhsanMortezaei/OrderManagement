using FluentValidation;
using Zamin.Extensions.Translations.Abstractions;

namespace AccountManagement.Core.RequestResponse.Accounts.Commands.Create;

// tarjome ha eslah shavad 
// file const baraye tarjome ijad shavad
public sealed class CreateAccountCommandValidator : AbstractValidator<CreateAccountCommand>
{
    public CreateAccountCommandValidator(ITranslator translator)
    {
        RuleFor(c => c.Username)
            .NotNull().WithMessage(translator["Required", "Title"])
            .MinimumLength(2).WithMessage(translator["Minimum Length {0} meghdar {1} mi bashad", "Title", "2"])
            .MinimumLength(2).WithMessage(string.Format(translator["Minimum Length {0} meghdar {1} mi bashad"], translator["Title"], 2))
            .MaximumLength(100).WithMessage(translator["MaximumLength", "Title", "100"]);

        RuleFor(c => c.Fullname)
            .NotNull().WithMessage(translator["Required", "Description"]).WithErrorCode("1")
            .MinimumLength(10).WithMessage(translator["MinimumLength", "Description", "10"]).WithErrorCode("2")
            .MaximumLength(500).WithMessage(translator["MaximumLength", "Description", "500"]).WithErrorCode("3");
    }
}
