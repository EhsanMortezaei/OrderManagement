using ShopManagement.Core.Contracts.ProductCategories.Command;
using ShopManagement.Core.RequestResponse.ProductCategories.Command.Delete;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace ShopManagement.Core.ApplicationService.ProductCategories.Command.Delete
{
    public class DeleteProductCategoryCommandHandler : CommandHandler<DeleteProductCategoryCommand>
    {
        private readonly IProductCategoryCommandRepository _productCategoryCommandRepository;

        public DeleteProductCategoryCommandHandler(ZaminServices zaminServices,
                                                   IProductCategoryCommandRepository productCategoryCommandRepository) : base(zaminServices)
        {
            _productCategoryCommandRepository = productCategoryCommandRepository;
        }


        public override async Task<CommandResult> Handle(DeleteProductCategoryCommand command)
        {
            var productCategory = await _productCategoryCommandRepository.GetGraphAsync(command.Id) ?? throw new InvalidEntityStateException("گروه محصولی یافت نشد");

            _productCategoryCommandRepository.Delete(productCategory);

            await _productCategoryCommandRepository.CommitAsync();

            return Ok();
        }
    }
}
