using InventoryManagement.Core.Domain.Inventories.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManagement.Infra.Data.Sql.Command.Inventories.Configs;

public sealed class InventoryOperationConfig : IEntityTypeConfiguration<InventoryOperation>
{
    public void Configure(EntityTypeBuilder<InventoryOperation> builder)
    {
        builder.Property(x => x.Description).HasMaxLength(1000).IsRequired();
    }
}
