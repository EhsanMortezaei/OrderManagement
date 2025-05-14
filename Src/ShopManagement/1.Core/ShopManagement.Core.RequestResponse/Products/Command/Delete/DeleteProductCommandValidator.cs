using FluentValidation;

namespace ShopManagement.Core.RequestResponse.Products.Command.Delete;

public sealed class DeleteProductCommandValidator : AbstractValidator<DeleteProductCommand>
{
    public DeleteProductCommandValidator()
    {
        RuleFor(x => x.Id)
            .GreaterThan(0)
            .WithMessage("شناسه محصول باید بزرگ‌تر از صفر باشد.");
    }
}
