namespace AccountManagement.Infra.Data.Sql.Queries.Models;

public partial class Role
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? ModifiedDateTime { get; set; }

    public Guid BusinessId { get; set; }
}
