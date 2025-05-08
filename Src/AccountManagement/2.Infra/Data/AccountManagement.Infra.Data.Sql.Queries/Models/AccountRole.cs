using System;
using System.Collections.Generic;

namespace AccountManagement.Infra.Data.Sql.Queries.Models;

public partial class AccountRole
{
    public int Id { get; set; }

    public int AccountId { get; set; }

    public int RoleId { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? ModifiedByUserId { get; set; }

    public DateTime? ModifiedDateTime { get; set; }

    public Guid BusinessId { get; set; }
}
