using ShopManagement.Core.Contracts.ProductCategories.Command;
using ShopManagement.Core.RequestResponse.ProductCategories.Command.Delete;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Contracts.Data.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace ShopManagement.Core.ApplicationService.ProductCategories.Command.Delete
{
    public class DeleteProductCategoryCommandHandler(ZaminServices zaminServices,
        IProductCategoryCommandRepository productCategoryCommandRepository,
        IUnitOfWork productUnitOfWork) : CommandHandler<DeleteProductCategoryCommand>(zaminServices)
    {
        private readonly IUnitOfWork productUnitOfWork = productUnitOfWork;
        private readonly IProductCategoryCommandRepository _productCategoryCommandRepository = productCategoryCommandRepository;

        public override async Task<CommandResult> Handle(DeleteProductCategoryCommand command)
        {
            var productCategory=await _productCategoryCommandRepository.GetGraphAsync(command.Id)??throw new InvalidEntityStateException("گروه محصولی یافت نشد");

            _productCategoryCommandRepository.Delete(productCategory);

            await _productCategoryCommandRepository.CommitAsync();

            return Ok();
        }
    }
}
