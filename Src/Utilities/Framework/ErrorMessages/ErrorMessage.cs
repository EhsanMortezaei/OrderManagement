namespace Framework.ErrorMessages;

public static class ErrorMessage
{
    public const string UsernameAlreadyExists = "نام کاربری وارد شده قبلاً ثبت شده است.";
    public const string UserNameAndPassword = "نام کاربری یا کلمه عبور اشتباه است.";
    public const string InvalidEmail = "ایمیل وارد شده معتبر نیست.";
    public const string PasswordTooShort = "کلمه عبور خیلی کوتاه است.";
    public const string MobileError = "شماره موبایل باید با 09 شروع شود و دقیقاً 11 رقم باشد.";
    public const string RoleError = "رول اکانت پیدا نشد";
    public const string Permission = "این پرمیشن قبلاً اضافه شده است";
    public const string NotAccount = "حساب یافت نشد";
    public const string InventoyError = "در انبار یافت نشد";
    public const string OrderError = "سفارش یافت نشد";
    public const string ProductCategoryError = "گروه محصولی یافت نشد";
    public const string DuplicateRoleName = "نام نقش تکراری است.";
    public const string ProductError = "محصول یافت نشد";
}
