using FluentValidation;
using Framework.ValidationMessages;
using Zamin.Extensions.Translations.Abstractions;

namespace AccountManagement.Core.RequestResponse.Permissions.Commands.Create;

public sealed class CreatePermissionCommandValidation : AbstractValidator<CreatePermissionCommand>
{
    public CreatePermissionCommandValidation(ITranslator translator)
    {
        RuleFor(x => x.Code)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdPermissionGreaterThanZero);

        RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage(ValidationMessages.NameRequired);

        RuleFor(x => x.RoleId)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdPermissionGreaterThanZero);

        RuleFor(x => x.AccountId)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.IdPermissionGreaterThanZero);
    }

}
