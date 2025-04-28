using AccountManagement.Core.Domain.Accounts.Events;
using AccountManagement.Core.Domain.Roles.Entities;
using Zamin.Core.Domain.Entities;

namespace AccountManagement.Core.Domain.Accounts.Entities
{
    public class Account : AggregateRoot<int>
    {
        public string Fullname { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Mobile { get; private set; }
        public int RoleId { get; private set; }
        //public Role Role { get; private set; }
        public string ProfilePhoto { get; private set; }

        public Account(string fullname,
                       string username,
                       string password,
                       string mobile,
                       int roleId,
                       string profilePhoto)
        {
            Fullname = fullname;
            Username = username;
            Password = password;
            Mobile = mobile;
            RoleId = roleId;

            if (roleId == 0)
            {
                RoleId = 2;
            }

            ProfilePhoto = profilePhoto;

            AddEvent(new AccountCreated(BusinessId.Value, Fullname, Username, Password, Mobile, RoleId, ProfilePhoto));
        }

        public void Edit(string fullname,
                         string username,
                         string mobile,
                         int roleId,
                         string profilePhoto)
        {
            Fullname = fullname;
            Username = username;
            Mobile = mobile;
            RoleId = roleId;
            if (!string.IsNullOrEmpty(profilePhoto))
            {
                ProfilePhoto = profilePhoto;
            }
        }

        public void ChangePassword(string password)
        {
            Password = password;
        }
    }
}
