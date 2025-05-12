namespace AccountManagement.Infra.Data.Sql.Queries.Models;

public partial class Account
{
    public int Id { get; set; }

    public string Fullname { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Mobile { get; set; } = null!;

    public string ProfilePhoto { get; set; } = null!;

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? ModifiedDateTime { get; set; }

    public Guid BusinessId { get; set; }
}
