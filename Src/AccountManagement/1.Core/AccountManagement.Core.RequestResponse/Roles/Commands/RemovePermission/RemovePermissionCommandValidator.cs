using FluentValidation;
using Framework.ValidationMessages;

namespace AccountManagement.Core.RequestResponse.Roles.Commands.RemovePermission;

public sealed class RemovePermissionCommandValidator : AbstractValidator<RemovePermissionCommand>
{
    public RemovePermissionCommandValidator()
    {
        RuleFor(x => x.PermissionId)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);

        RuleFor(x => x.RoleId)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);
    }
}

