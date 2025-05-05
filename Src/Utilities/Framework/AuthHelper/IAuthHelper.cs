using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.AuthHelper
{
    public interface IAuthHelper
    {
        void SignOut();
        bool IsAuthenticated();
        void Signin(AuthViewModel account);
        string CurrentAccountRole();
        AuthViewModel CurrentAccountInfo();
        List<int> GetPermissions();
        long CurrentAccountId();
    }
}
