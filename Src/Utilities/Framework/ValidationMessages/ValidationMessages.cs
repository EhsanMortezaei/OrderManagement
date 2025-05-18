namespace Framework.ValidationMessages;

public static class ValidationMessages
{
    //public const string Required = "ولیدیشن اجباری است";
    public const string MinimumLength = "Validation.MinimumLength";
    public const string MaximumLength = "Validation.MaximumLength";
    public const string IdGreaterThanZero = "شناسه باید بزرگ‌تر از صفر باشد.";
    public const string Required = "فیلد {PropertyName} اجباری است.";
    public const string NotNull = "عملیات نمی‌تواند null باشد.";
    public const string UserNameRequired = "نام کاربری نمی‌تواند خالی باشد.";
    public const string FullnameRequired = "نام کامل نمی‌تواند خالی باشد.";
    public const string PasswordRequired = "رمز عبور نمی‌تواند خالی باشد.";
    public const string PasswordLength = "رمز عبور باید حداقل ۶ و حداکثر ۱۰۰ کاراکتر باشد.";
    public const string MobileRequired = "شماره موبایل نمی‌تواند خالی باشد.";
    public const string NameRequired = "نام  نمی‌تواند خالی باشد.";
    public const string MobileInvalid = "شماره موبایل وارد شده معتبر نیست.";
    public const string AccountIdRequired = "شناسه حساب الزامی است.";
    public const string PaymentMethodInvalid = "روش پرداخت نامعتبر است.";
    public const string TotalAmountNonNegative = "مبلغ کل نمی‌تواند منفی باشد.";
    public const string DiscountAmountNonNegative = "مبلغ تخفیف نمی‌تواند منفی باشد.";
    public const string PayAmountNonNegative = "مبلغ پرداخت نمی‌تواند منفی باشد.";
    public const string IssueTrackingRequired = "شماره پیگیری الزامی است.";
    public const string IssueTrackingMaxLength = "شماره پیگیری نباید بیش از ۲۰ کاراکتر باشد.";
    public const string RefIdNonNegative = "شناسه مرجع باید عددی نامنفی باشد.";
    public const string OrderItemsRequired = "اقلام سفارش الزامی هستند.";
    public const string OrderMustHaveItems = "سفارش باید حداقل یک قلم داشته باشد.";
    public const string IdPermissionGreaterThanZero = " دسترسی نمی‌تواند خالی باشد.";
    public const string PriceGreaterThanZero = "قیمت باید بزرگ‌تر از صفر باشد.";
    public const string AtLeastOneItem = "حداقل یک مورد باید وارد شود.";
    public const string CountGreaterThanZero = "تعداد باید بزرگ‌تر از صفر باشد.";
    public const string AmountGreaterThanZero = "مقدار {PropertyName} باید بزرگ‌تر از صفر باشد.";
    public const string InvalidPaymentMethod = "روش پرداخت انتخاب شده معتبر نیست.";
    public const string UnitPriceGreaterThanZero = "قیمت واحد باید بزرگ‌تر از صفر باشد.";
    public const string OperationsRequired = "لیست عملیات نمی‌تواند خالی باشد.";
    public const string InvalidDate = "تاریخ عملیات معتبر نیست.";
    public const string DiscountRateValid = "میزان تخفیف باید بین 0 و 100 باشد.";
    public const string InvalidSlug = "Slug باید یک مقدار یکتا و بدون فاصله باشد.";
    public const string DuplicateRoleName = "نام نقش تکراری است.";
    public const string DuplicateInventory = "برای این محصول قبلاً موجودی تعریف شده است.";
    public const string NegativePrice = "قیمت نمی‌تواند منفی باشد.";
    public const string NegativeStock = "موجودی اولیه نمی‌تواند منفی باشد.";
    public const string InvalidOperation = "برخی عملیات وارد شده نامعتبر هستند.";
}
