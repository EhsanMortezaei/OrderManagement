using FluentValidation;
using Zamin.Extensions.Translations.Abstractions;

namespace AccountManagement.Core.RequestResponse.Accounts.Queries.GetAccountById;

// query va command validaator ha takmil shavad
public sealed class GetAccountByIdQueryValidator : AbstractValidator<GetAccountByIdQuery>
{
    public GetAccountByIdQueryValidator(ITranslator translator)
    {
        RuleFor(query => query.AccountId)
            .NotEmpty()
            .WithMessage(translator["Required", nameof(GetAccountByIdQuery.AccountId)]);
    }
}
