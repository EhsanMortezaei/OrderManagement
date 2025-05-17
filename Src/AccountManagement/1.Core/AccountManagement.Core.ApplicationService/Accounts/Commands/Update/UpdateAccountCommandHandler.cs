using AccountManagement.Core.Contract.Accounts.Commands;
using AccountManagement.Core.RequestResponse.Accounts.Commands.Update;
using Framework.Enums.Validation;
using Framework.FileUpload;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace AccountManagement.Core.ApplicationService.Accounts.Commands.Update;

public sealed class UpdateAccountCommandHandler(ZaminServices zainServices,
    IAccountCommandRepository accountCommandRepository,
    IFileUploader fileUploader) : CommandHandler<UpdateAccountCommand>(zainServices)
{
    public override async Task<CommandResult> Handle(UpdateAccountCommand command)
    {
        if (accountCommandRepository.Exists(c => c.Username == command.Username))
            throw new InvalidEntityStateException(ErrorMessages.Get(ErrorMessageKey.UsernameAlreadyExists));

        var path = $"profilePhotos";
        var profilePhoto = fileUploader.Upload(command.ProfilePhoto, path);

        var account = await accountCommandRepository.GetAsync(command.Id)
            ?? throw new InvalidEntityStateException(ErrorMessages.Get(ErrorMessageKey.NotAccount));
        account.Edit(command.Fullname,
                     command.Username,
                     command.Mobile,
                     profilePhoto);
        await accountCommandRepository.CommitAsync();
        return Ok();
    }
}
