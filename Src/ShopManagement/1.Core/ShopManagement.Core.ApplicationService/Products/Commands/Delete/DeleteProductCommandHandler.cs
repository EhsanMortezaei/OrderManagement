using ShopManagement.Core.Contracts.Products.Command;
using ShopManagement.Core.RequestResponse.Products.Command.Delete;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Contracts.Data.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace ShopManagement.Core.ApplicationService.Products.Commands.Delete
{
    public sealed class DeleteProductCommandHandler(ZaminServices zaminServices,
                                      IProductCommandRepository productCommandRepository,
                                      IUnitOfWork productUnitOfWork) : CommandHandler<DeleteProductCommand>(zaminServices)
    {
        private readonly IUnitOfWork _productUnitOfWork = productUnitOfWork;
        private readonly IProductCommandRepository _productCommandRepository = productCommandRepository;

        public override async Task<CommandResult> Handle(DeleteProductCommand command)
        {
            var product = await _productCommandRepository.GetGraphAsync(command.Id) ?? throw new InvalidEntityStateException("محصول یافت نشد");

            _productCommandRepository.Delete(product);

            await _productCommandRepository.CommitAsync();

            return Ok();
        }
    }
}
