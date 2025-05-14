using FluentValidation;
using Framework.ValidationMessages;

namespace AccountManagement.Core.RequestResponse.Permissions.Commands.Update;

public sealed class UpdatePermissionCommandValidator : AbstractValidator<UpdatePermissionCommand>
{
    public UpdatePermissionCommandValidator()
    {
        RuleFor(x => x.Id)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);

        RuleFor(x => x.Code)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);

        RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage(ValidationMessages.NameRequired);

        RuleFor(x => x.RoleId)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);

        RuleFor(x => x.AccountId)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdGreaterThanZero);
    }
}

