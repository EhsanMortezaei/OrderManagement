using System.ComponentModel;

namespace Framework.Enums.Validation;

public static class ErrorMessages
{
     static readonly Dictionary<ErrorMessageKey, string> _messages = new()
{
    { ErrorMessageKey.UsernameAlreadyExists, "نام کاربری وارد شده قبلاً ثبت شده است." },
    { ErrorMessageKey.InvalidEmail, "ایمیل وارد شده معتبر نیست." },
    { ErrorMessageKey.PasswordTooShort, "کلمه عبور خیلی کوتاه است." },
    {ErrorMessageKey.MobileError,"شماره موبایل باید با 09 شروع شود و دقیقاً 11 رقم باشد." }
};

    public static string Get(ErrorMessageKey key)
    {
        return _messages.TryGetValue(key, out var message) ? message : "خطای نامشخص.";
    }
}

public enum ErrorMessageKey
{
    UsernameAlreadyExists,
    InvalidEmail,
    PasswordTooShort,
    [Description("خطا موبایل")]
    MobileError
}
