using System;
using System.Collections.Generic;

namespace AccountManagement.Infra.Data.Sql.Queries.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string ShortDescription { get; set; } = null!;

    public string Descrption { get; set; } = null!;

    public string Picture { get; set; } = null!;

    public string PictureAlt { get; set; } = null!;

    public string PictureTitle { get; set; } = null!;

    public int ProductCategoryId { get; set; }

    public string Slug { get; set; } = null!;

    public string Keywords { get; set; } = null!;

    public string MetaDescription { get; set; } = null!;

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? ModifiedDateTime { get; set; }

    public Guid BusinessId { get; set; }
}
