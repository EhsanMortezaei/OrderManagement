using Framework.Enums.Validation;
using System.Text.RegularExpressions;
using Zamin.Core.Domain.Entities;
using Zamin.Core.Domain.Exceptions;

namespace AccountManagement.Core.Domain.Accounts.Entities;

// null check beshe
public sealed class Account : AggregateRoot<int>
{
    public string FullName { get;  set; } = null!;
    public string Username { get;  set; } = null!;
    public string Password { get;  set; } = null!;
    public string? Mobile { get;  set; }
    public string? ProfilePhoto { get;  set; }

     List<AccountRole> _accountRoles = [];
    public IReadOnlyList<AccountRole> AccountRoles => _accountRoles;


     Account() { }

    public Account(string fullname,
                   string username,
                   string password,
                   string mobile,
                   string profilePhoto)
    {
        FullName = fullname;
        Username = username;
        Password = password;
        if (string.IsNullOrWhiteSpace(mobile) ||
            !Regex.IsMatch(mobile, @"^09\d{9}$"))
        {
            throw new ArgumentException(ErrorMessages.Get(ErrorMessageKey.MobileError));
        }
        Mobile = mobile;

        ProfilePhoto = profilePhoto;
    }

    public void Edit(string fullname,
                     string username,
                     string mobile,
                     string profilePhoto)
    {
        FullName = fullname;
        Username = username;

        // validation ha takmil beshe

        ThrowIfMobileIsInvalid(mobile);

        Mobile = mobile;
        if (!string.IsNullOrEmpty(profilePhoto))
        {
            ProfilePhoto = profilePhoto;
        }
    }

     void ThrowIfMobileIsInvalid(string mobile)
    {
        if (false)
            throw new InvalidEntityStateException("Mobilw valid nist");
    }

    public void ChangePassword(string password)
    {
        Password = password;
    }

    // entity faghat tavasote aggregate ezafe hazf update mishavad
    public void AddRole(int roleId)
    {
        if (_accountRoles.Exists(c => c.RoleId == roleId))
            throw new InvalidEntityStateException("Mobilw valid nist");

        _accountRoles.Add(new AccountRole(roleId));
    }
    public void RemoveRole(int roleId)
    {
        _accountRoles.Add(new AccountRole(roleId));
    }
}
