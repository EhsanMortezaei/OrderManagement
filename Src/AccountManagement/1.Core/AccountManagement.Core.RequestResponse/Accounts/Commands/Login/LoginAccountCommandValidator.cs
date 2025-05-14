using FluentValidation;
using Framework.ValidationMessages;

namespace AccountManagement.Core.RequestResponse.Accounts.Commands.Login;

public sealed class LoginAccountCommandValidator : AbstractValidator<LoginAccountCommand>
{
    public LoginAccountCommandValidator()
    {
        RuleFor(x => x.UserName)
            .NotEmpty()
            .WithMessage(ValidationMessages.UserNameRequired);

        RuleFor(x => x.Password)
            .NotEmpty()
            .WithMessage(ValidationMessages.PasswordRequired)
            .MinimumLength(6)
            .WithMessage(ValidationMessages.PasswordLength)
            .MaximumLength(100)
            .WithMessage(ValidationMessages.PasswordLength);
    }
}
