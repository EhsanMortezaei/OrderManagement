using InventoryManagement.Core.Domain.Inventories.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManagement.Infra.Data.Sql.Command.InventoryOperations.Configs
{
    public class InventoryOperationConfig : IEntityTypeConfiguration<InventoryOperation>
    {
        public void Configure(EntityTypeBuilder<InventoryOperation> builder)
        {
            builder.Property(x => x.Description).HasMaxLength(1000).IsRequired();
        }
    }
}
