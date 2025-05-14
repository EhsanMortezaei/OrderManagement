using FluentValidation;
using Framework.ValidationMessages;

namespace AccountManagement.Core.RequestResponse.Accounts.Commands.Update;

public sealed class UpdateAccountCommandValidator : AbstractValidator<UpdateAccountCommand>
{
    public UpdateAccountCommandValidator()
    {
        RuleFor(x => x.Id)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);

        RuleFor(x => x.Fullname)
            .NotEmpty()
            .WithMessage(ValidationMessages.FullnameRequired);

        RuleFor(x => x.Username)
            .NotEmpty()
            .WithMessage(ValidationMessages.UserNameRequired);

        RuleFor(x => x.Password)
            .NotEmpty()
            .WithMessage(ValidationMessages.PasswordRequired)
            .MinimumLength(6)
            .WithMessage(ValidationMessages.PasswordLength);

        RuleFor(x => x.Mobile)
            .NotEmpty()
            .WithMessage(ValidationMessages.MobileRequired)
            .Matches(@"^(\+98|0)?9\d{9}$")
            .WithMessage(ValidationMessages.MobileInvalid);
    }
}

