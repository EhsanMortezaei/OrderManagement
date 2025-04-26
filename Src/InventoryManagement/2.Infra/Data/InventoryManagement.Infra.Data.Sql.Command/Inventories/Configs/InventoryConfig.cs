using InventoryManagement.Core.Domain.Inventories.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManagement.Infra.Data.Sql.Command.Inventories.Configs
{
    public class InventoryConfig : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> builder)
        {
            throw new NotImplementedException();
        }
    }
}
