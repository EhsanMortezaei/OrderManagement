using FluentValidation;
using Zamin.Extensions.Translations.Abstractions;

namespace AccountManagement.Core.RequestResponse.Permissions.Commands.Create
{
    public class CreatePermissionCommandValidation : AbstractValidator<CreatePermissionCommand>
    {
        public CreatePermissionCommandValidation(ITranslator translator)
        {
            RuleFor(c => c.Name)
                .NotNull().WithMessage(translator["Required", "Name"])
                .MinimumLength(2).WithMessage(translator["MinimumLength", "Name", "2"])
                .MaximumLength(100).WithMessage(translator["MaximumLength", "Name", "100"]);
        }

    }
}
