using FluentValidation;
using Framework.ValidationMessages;

namespace AccountManagement.Core.RequestResponse.Roles.Commands.AddPermission;

public sealed class AddPermissionCommandValidator : AbstractValidator<AddPermissionCommand>
{
    public AddPermissionCommandValidator()
    {
        RuleFor(x => x.Code)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);

        RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage(ValidationMessages.NameRequired);

        RuleFor(x => x.RoleId)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);
    }
}
