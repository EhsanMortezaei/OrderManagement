using FluentValidation;
using Zamin.Extensions.Translations.Abstractions;

namespace AccountManagement.Core.RequestResponse.Permissions.Queries;

public sealed class GetPermissionByIdQueryValidator : AbstractValidator<GetPermissionByIdQuery>
{
    public GetPermissionByIdQueryValidator(ITranslator translator)
    {
        RuleFor(query => query.PermissionId)
            .NotEmpty()
            .WithMessage(translator["Required", nameof(GetPermissionByIdQuery.PermissionId)]);
    }
}
