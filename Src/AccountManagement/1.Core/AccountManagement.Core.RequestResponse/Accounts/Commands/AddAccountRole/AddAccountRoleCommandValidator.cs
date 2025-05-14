using FluentValidation;
using Framework.ValidationMessages;

namespace AccountManagement.Core.RequestResponse.Accounts.Commands.AddAccountRole;

public sealed class AddAccountRoleCommandValidator : AbstractValidator<AddAccountRoleCommand>
{
    public AddAccountRoleCommandValidator()
    {
        RuleFor(x => x.AccountId)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);

        RuleFor(x => x.RoleId)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);
    }
}
