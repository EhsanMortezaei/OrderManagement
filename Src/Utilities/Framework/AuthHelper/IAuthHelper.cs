﻿namespace Framework.AuthHelper;

public interface IAuthHelper
{
    void SignOut();
    bool IsAuthenticated();
    void Signin(AuthViewModel account);
    string? CurrentAccountRole();
    AuthViewModel CurrentAccountInfo();
    List<int> GetPermissions();
    long CurrentAccountId();
}
