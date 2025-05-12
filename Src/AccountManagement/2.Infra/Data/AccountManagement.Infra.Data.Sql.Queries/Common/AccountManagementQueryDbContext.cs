using AccountManagement.Infra.Data.Sql.Queries.Models;
using Microsoft.EntityFrameworkCore;
using Zamin.Infra.Data.Sql.Queries;

namespace AccountManagement.Infra.Data.Sql.Queries.Common;

public partial class AccountManagementQueryDbContext : BaseQueryDbContext
{
    public AccountManagementQueryDbContext(DbContextOptions<AccountManagementQueryDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<AccountRole> AccountRoles { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<ParrotTranslation> ParrotTranslations { get; set; }

    public virtual DbSet<Permission> Permissions { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductCategory> ProductCategories { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog=Order; Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.Property(e => e.CreatedByUserId).HasMaxLength(50);
            entity.Property(e => e.ModifiedByUserId).HasMaxLength(50);
        });

        modelBuilder.Entity<AccountRole>(entity =>
        {
            entity.ToTable("AccountRole");

            entity.Property(e => e.CreatedByUserId).HasMaxLength(50);
            entity.Property(e => e.ModifiedByUserId).HasMaxLength(50);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.Property(e => e.CreatedByUserId).HasMaxLength(50);
            entity.Property(e => e.ModifiedByUserId).HasMaxLength(50);
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.HasIndex(e => e.OrderId1, "IX_OrderItems_OrderId1");

            entity.Property(e => e.CreatedByUserId).HasMaxLength(50);
            entity.Property(e => e.ModifiedByUserId).HasMaxLength(50);

            entity.HasOne(d => d.OrderId1Navigation).WithMany(p => p.OrderItems).HasForeignKey(d => d.OrderId1);
        });

        modelBuilder.Entity<ParrotTranslation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ParrotTr__3214EC07953A8AD7");

            entity.HasIndex(e => e.BusinessId, "UQ__ParrotTr__F1EAA36F52E3639E").IsUnique();

            entity.Property(e => e.BusinessId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Culture).HasMaxLength(5);
            entity.Property(e => e.Key).HasMaxLength(255);
            entity.Property(e => e.Value).HasMaxLength(500);
        });

        modelBuilder.Entity<Permission>(entity =>
        {
            entity.Property(e => e.CreatedByUserId).HasMaxLength(50);
            entity.Property(e => e.ModifiedByUserId).HasMaxLength(50);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.CreatedByUserId).HasMaxLength(50);
            entity.Property(e => e.ModifiedByUserId).HasMaxLength(50);
        });

        modelBuilder.Entity<ProductCategory>(entity =>
        {
            entity.Property(e => e.CreatedByUserId).HasMaxLength(50);
            entity.Property(e => e.ModifiedByUserId).HasMaxLength(50);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.Property(e => e.CreatedByUserId).HasMaxLength(50);
            entity.Property(e => e.ModifiedByUserId).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
