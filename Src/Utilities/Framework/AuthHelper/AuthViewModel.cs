namespace Framework.AuthHelper;

public sealed class AuthViewModel
{
    public long Id { get; set; }
    public long RoleId { get; set; }
    public string Role { get; set; } = string.Empty;
    public string Fullname { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public List<int>? Permissions { get; set; }

    // nuull bodan ha check shavad
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