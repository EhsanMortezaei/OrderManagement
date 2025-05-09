using System.Collections.Generic;

namespace Framework.AuthHelper
{
    public class AuthViewModel
    {
        public long Id { get; set; }
        public long RoleId { get; set; }
        public string Role { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        public List<int> Permissions { get; set; }

        public AuthViewModel()
        {
        }

        public AuthViewModel(long id, string fullname, string username)
        {
            Id = id;
            Fullname = fullname;
            Username = username;
        }
    }
}