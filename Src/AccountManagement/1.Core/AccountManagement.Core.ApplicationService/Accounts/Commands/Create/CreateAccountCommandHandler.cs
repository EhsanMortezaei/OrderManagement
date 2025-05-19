using AccountManagement.Core.Contract.Accounts.Commands;
using AccountManagement.Core.Domain.Accounts.Entities;
using AccountManagement.Core.RequestResponse.Accounts.Commands.Create;
using Framework.ErrorMessages;
using Framework.FileUpload;
using Framework.PasswordHasher;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace AccountManagement.Core.ApplicationService.Accounts.Commands.Create;

public sealed class CreateAccountCommandHandler(ZaminServices zaminServices,
    IAccountCommandRepository accountCommandRepository,
    IPasswordHasher passwordHasher, IFileUploader fileUploader) : CommandHandler<CreateAccountCommand, Guid>(zaminServices)
{
    public override async Task<CommandResult<Guid>> Handle(CreateAccountCommand command)
    {
        // validation hai ke niaz be check db darad dakhele command handler check shavad
        if (accountCommandRepository.Exists(c => c.Username == command.Username))
            throw new InvalidEntityStateException(ErrorMessage.UsernameAlreadyExists);

        var path = $"profilePhotos";
        var profilePhoto = fileUploader.Upload(command.ProfilePhoto, path);

        var hashedPassword = passwordHasher.Hash(command.Password);
        var account = new Account(command.Fullname,
                                  command.Username,
                                  hashedPassword,
                                  command.Mobile,
                                  profilePhoto);

        await accountCommandRepository.InsertAsync(account);
        await accountCommandRepository.CommitAsync();

        return Ok(account.BusinessId.Value);
    }
}
