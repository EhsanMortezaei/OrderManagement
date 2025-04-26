using AccountManagement.Core.RequestResponse.Accounts.Queries;
using FluentValidation;
using Zamin.Extensions.Translations.Abstractions;

namespace AccountManagement.Core.RequestResponse.Roles.Queries
{
    public class GetRoleByIdQueryValidator : AbstractValidator<GetRoleByIdQuery>
    {
        public GetRoleByIdQueryValidator(ITranslator translator)
        {
            RuleFor(query => query.RoleId)
                .NotEmpty()
                .WithMessage(translator["Required", nameof(GetRoleByIdQuery.RoleId)]);
        }
    }
}
