using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Security.Claims;

namespace Framework.AuthHelper;

public sealed class AuthHelper(IHttpContextAccessor contextAccessor) : IAuthHelper
{
    public AuthViewModel CurrentAccountInfo()
    {
        //var result = new AuthViewModel();
        //if (!IsAuthenticated())
        //    return result;

        //var claims = _contextAccessor.HttpContext.User.Claims.ToList();
        //result.Id = long.Parse(claims.FirstOrDefault(x => x.Type == "AccountId").Value);
        //result.Username = claims.FirstOrDefault(x => x.Type == "Username").Value;
        //result.RoleId = long.Parse(claims.FirstOrDefault(x => x.Type == ClaimTypes.Role).Value);
        //result.Fullname = claims.FirstOrDefault(x => x.Type == ClaimTypes.Name).Value;
        //result.Role = Roles.GetRoleBy(result.RoleId);
        //return result;
        var result = new AuthViewModel();
        if (!IsAuthenticated())
            return result;

        var claims = contextAccessor.HttpContext?.User?.Claims?.ToList();
        if (claims == null)
            return result;

        var accountIdClaim = claims.FirstOrDefault(x => x.Type == "AccountId");
        var usernameClaim = claims.FirstOrDefault(x => x.Type == ClaimTypes.Name);
        var roleIdClaim = claims.FirstOrDefault(x => x.Type == ClaimTypes.Role);
        var fullnameClaim = claims.FirstOrDefault(x => x.Type == "FullName");

        if (accountIdClaim != null && long.TryParse(accountIdClaim.Value, out var accountId))
            result.Id = accountId;

        if (usernameClaim != null)
            result.Username = usernameClaim.Value;

        if (roleIdClaim != null && long.TryParse(roleIdClaim.Value, out var roleId))
            result.RoleId = roleId;

        if (fullnameClaim != null)
            result.Fullname = fullnameClaim.Value;

        return result;

    }

    //public List<int> GetPermissions()
    //{
    //    if (!IsAuthenticated())
    //        return new List<int>();

    //    var permissions = _contextAccessor.HttpContext.User.Claims.FirstOrDefault(x => x.Type == "permissions")
    //        ?.Value;
    //    return JsonConvert.DeserializeObject<List<int>>(permissions);
    //}

    public List<int> GetPermissions()
    {
        if (!IsAuthenticated())
            return new List<int>();

        var permissions = contextAccessor.HttpContext.User.Claims
            .FirstOrDefault(x => x.Type == "permissions")?.Value;

        return permissions != null
            ? JsonConvert.DeserializeObject<List<int>>(permissions) ?? new List<int>()
            : new List<int>();
    }


    public long CurrentAccountId()
    {
        if (IsAuthenticated())
        {
            var accountIdClaim = contextAccessor.HttpContext?.User?.Claims
                .FirstOrDefault(x => x.Type == "AccountId")?.Value;

            if (!string.IsNullOrWhiteSpace(accountIdClaim) && long.TryParse(accountIdClaim, out var accountId))
                return accountId;
        }

        return 0;
    }


    public string? CurrentAccountRole()
    {
        if (IsAuthenticated())
            return contextAccessor.HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Role)?.Value;
        return null;
    }

    public bool IsAuthenticated()
    {
        return contextAccessor.HttpContext?.User?.Identity?.IsAuthenticated ?? false;
    }


    public void Signin(AuthViewModel account)
    {
        var permissions = JsonConvert.SerializeObject(account.Permissions);
        var claims = new List<Claim>
        {
            new("AccountId", account.Id.ToString()),
            new Claim(ClaimTypes.Name, account.Fullname),
            new Claim(ClaimTypes.Role, account.RoleId.ToString()),
            new Claim(ClaimTypes.Role, account.RoleId.ToString()),
            new Claim("Username", account.Username), // Or Use ClaimTypes.NameIdentifier
            new Claim("permissions", permissions),
            //new Claim("Mobile", account.Mobile)
        };

        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

        var authProperties = new AuthenticationProperties
        {
            ExpiresUtc = DateTimeOffset.UtcNow.AddDays(1)
        };

        contextAccessor.HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
            new ClaimsPrincipal(claimsIdentity),
            authProperties);
    }

    public void SignOut()
    {
        contextAccessor.HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
    }
}