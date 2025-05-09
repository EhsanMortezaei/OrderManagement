using AccountManagement.Core.Domain.Accounts.Events;
using Zamin.Core.Domain.Entities;

namespace AccountManagement.Core.Domain.Accounts.Entities
{
    public class Account : AggregateRoot<int>
    {
        public string Fullname { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Mobile { get; private set; }
        public string ProfilePhoto { get; private set; }

        protected Account() { }

        public Account(string fullname,
                       string username,
                       string password,
                       string mobile,
                       string profilePhoto)
        {
            Fullname = fullname;
            Username = username;
            Password = password;
            Mobile = mobile;

            ProfilePhoto = profilePhoto;

            AddEvent(new AccountCreated(BusinessId.Value, Fullname, Username, Password, Mobile, ProfilePhoto));
        }

        public static Account Create(string fullname, string username, string password, string mobile, string profilePhoto)
            => new Account(fullname, username, password, mobile, profilePhoto);

        public void Edit(string fullname,
                         string username,
                         string mobile,
                         string profilePhoto)
        {
            Fullname = fullname;
            Username = username;
            Mobile = mobile;
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
