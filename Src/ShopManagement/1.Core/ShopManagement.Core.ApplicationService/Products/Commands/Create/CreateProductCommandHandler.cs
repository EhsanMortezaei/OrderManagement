using ShopManagement.Core.Contracts.Products.Command;
using ShopManagement.Core.Domain.Products.Entities;
using ShopManagement.Core.RequestResponse.Products.Command.Create;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace ShopManagement.Core.ApplicationService.Products.Commands.Create
{
    public class CreateProductCommandHandler : CommandHandler<CreateProductCommand, Guid>
    {
        private readonly IProductCommandRepository _productCommandRepository;

        public CreateProductCommandHandler(ZaminServices zaminServices,
            IProductCommandRepository productCommandRepository) : base(zaminServices)
        {
            _productCommandRepository = productCommandRepository;
        }

        public override async Task<CommandResult<Guid>> Handle(CreateProductCommand command)
        {
            //var entity = await _productCommandRepository.GetAsync(command.Id);
            //if (entity is null)
            //{
            //    throw new Exception("id نمیتواند خالی باشد") ;
            //}
            var product = new Product(command.Name,
                                      command.Code,
                                      command.ShortDescription,
                                      command.Descrption,
                                      command.Picture,
                                      command.PictureAlt,
                                      command.PictureTitle,
                                      command.CategoryId,
                                      command.Slug,
                                      command.Keywords,
                                      command.MetaDescription);
            await _productCommandRepository.InsertAsync(product);
            await _productCommandRepository.CommitAsync();

            return Ok(product.BusinessId.Value);
        }
    }
}
