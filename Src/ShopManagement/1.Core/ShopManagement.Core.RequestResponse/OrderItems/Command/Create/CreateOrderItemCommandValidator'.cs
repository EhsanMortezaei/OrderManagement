using FluentValidation;
using ShopManagement.Core.RequestResponse.Orders.Command.Create;
using Zamin.Extensions.Translations.Abstractions;

namespace ShopManagement.Core.RequestResponse.OrderItems.Command.Create
{
    public class CreateOrderItemCommandValidator : AbstractValidator<CreateOrderCommand>
    {
        public CreateOrderItemCommandValidator(ITranslator translator)
        {
            
        }
    }
}
