using System.ComponentModel;

namespace Framework.Enums.Validation;

public static class ErrorMessages
{
    static readonly Dictionary<ErrorMessageKey, string> _messages = new()
{
    {ErrorMessageKey.UsernameAlreadyExists, "نام کاربری وارد شده قبلاً ثبت شده است." },
    {ErrorMessageKey.UserNameAndPassword, "نام کاربری یا کلمه عبور اشتباه است." },
    {ErrorMessageKey.InvalidEmail, "ایمیل وارد شده معتبر نیست." },
    {ErrorMessageKey.PasswordTooShort, "کلمه عبور خیلی کوتاه است." },
    {ErrorMessageKey.MobileError,"شماره موبایل باید با 09 شروع شود و دقیقاً 11 رقم باشد." },
    {ErrorMessageKey.RoleError,"رول اکانت پیدا نشد" },
    {ErrorMessageKey.Permission,"این پرمیشن قبلاً اضافه شده است" },
    {ErrorMessageKey.NotAccount,"حساب یافت نشد"},
    {ErrorMessageKey.InventoyError,"در انبار یافت نشد"},
    {ErrorMessageKey.OrderError,"سفارش یافت نشد"},
    {ErrorMessageKey.ProductCategoryError,"گروه محصولی یافت نشد"},
    {ErrorMessageKey.ProductError,"محصول یافت نشد"}
};

    public static string Get(ErrorMessageKey key)
    {
        return _messages.TryGetValue(key, out var message) ? message : "خطای نامشخص.";
    }
}

public enum ErrorMessageKey
{
    UsernameAlreadyExists,
    UserNameAndPassword,
    InvalidEmail,
    PasswordTooShort,
    [Description("خطا موبایل")]
    MobileError,
    RoleError,
    Permission,
    NotAccount,
    InventoyError,
    OrderError,
    ProductCategoryError,
    ProductError
}

