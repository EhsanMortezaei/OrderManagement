namespace AccountManagement.Infra.Data.Sql.Queries.Models;

public partial class ProductCategory
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Picture { get; set; } = null!;

    public string PictureAlt { get; set; } = null!;

    public string PictureTitle { get; set; } = null!;

    public string KeyWords { get; set; } = null!;

    public string MetaDescription { get; set; } = null!;

    public string Slug { get; set; } = null!;

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? ModifiedDateTime { get; set; }

    public Guid BusinessId { get; set; }
}
