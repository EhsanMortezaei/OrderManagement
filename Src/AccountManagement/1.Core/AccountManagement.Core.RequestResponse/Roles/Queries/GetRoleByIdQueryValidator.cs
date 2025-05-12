using FluentValidation;
using Zamin.Extensions.Translations.Abstractions;

namespace AccountManagement.Core.RequestResponse.Roles.Queries;

public sealed class GetRoleByIdQueryValidator : AbstractValidator<GetRoleByIdQuery>
{
    public GetRoleByIdQueryValidator(ITranslator translator)
    {
        RuleFor(query => query.RoleId)
            .NotEmpty()
            .WithMessage(translator["Required", nameof(GetRoleByIdQuery.RoleId)]);
    }
}
