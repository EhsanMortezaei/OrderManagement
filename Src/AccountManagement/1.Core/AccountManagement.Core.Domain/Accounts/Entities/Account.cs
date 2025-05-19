using Framework.ErrorMessages;
using Framework.ValidationMessages;
using System.Text.RegularExpressions;
using Zamin.Core.Domain.Entities;
using Zamin.Core.Domain.Exceptions;

namespace AccountManagement.Core.Domain.Accounts.Entities;

// null check beshe
public sealed class Account : AggregateRoot<int>
{
    #region Properties
    public string FullName { get; private set; } = null!;
    public string Username { get; private set; } = null!;
    public string Password { get; private set; } = null!;
    public string? Mobile { get; private set; }
    public string? ProfilePhoto { get; private set; }

    private readonly List<AccountRole> _accountRoles = [];
    public IReadOnlyList<AccountRole> AccountRoles => _accountRoles;
    #endregion

    #region Constructors
    private Account() { }

    public Account(string fullname,
                   string username,
                   string password,
                   string mobile,
                   string profilePhoto)
    {
        FullName = fullname;
        Username = username;
        Password = password;
        Mobile = mobile;
        ProfilePhoto = profilePhoto;

        Validate();
    }
    #endregion

    #region Commands
    public void Edit(string fullname,
                     string username,
                     string mobile,
                     string profilePhoto)
    {
        FullName = fullname;
        Username = username;
        Mobile = mobile;
        if (!string.IsNullOrEmpty(profilePhoto))
            ProfilePhoto = profilePhoto;
        Validate();
    }

    public void ChangePassword(string password) => Password = password;

    // entity faghat tavasote aggregate ezafe hazf update mishavad
    public void AddRole(int roleId)
    {
        if (_accountRoles.Exists(c => c.RoleId == roleId))
            throw new InvalidEntityStateException(ErrorMessage.RoleError);

        _accountRoles.Add(new AccountRole(roleId));
    }
    public void RemoveRole(int roleId)
    {
        var accountRole = _accountRoles.FirstOrDefault(x => x.RoleId == roleId)
            ?? throw new InvalidEntityStateException(ErrorMessage.RoleError);
        _accountRoles.Remove(accountRole);
    }
    #endregion

    #region Methods
    private void Validate()
    {
        if (string.IsNullOrWhiteSpace(FullName))
            throw new InvalidEntityStateException(ValidationMessages.FullnameRequired);

        if (string.IsNullOrWhiteSpace(Username))
            throw new InvalidEntityStateException(ValidationMessages.UserNameRequired);

        if (string.IsNullOrWhiteSpace(Password))
            throw new InvalidEntityStateException(ValidationMessages.PasswordRequired);

        if (string.IsNullOrWhiteSpace(Mobile) || !Regex.IsMatch(Mobile, @"^09\d{9}$"))
            throw new InvalidEntityStateException(ErrorMessage.MobileError);
    }
    #endregion
}
