using FluentValidation;
using Framework.ValidationMessages;

namespace AccountManagement.Core.RequestResponse.Accounts.Commands.RemoveAccountRole;

public sealed class RemoveAccountRoleCommandValidator : AbstractValidator<RemoveAccountRoleCommand>
{
    public RemoveAccountRoleCommandValidator()
    {
        RuleFor(x => x.AccountId)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);

        RuleFor(x => x.RoleId)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);
    }
}

