using eShop.Domain.Enitities;
using eShop.Domain.Enitities.Baskets;
using eShop.Domain.Enitities.Orders;
using eShop.Domain.Enitities.Organizations;
using eShop.Domain.Enitities.Products;
using eShop.Domain.Enitities.Regions;
using eShop.Domain.Enitities.Users;
using eShop.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace eShop.Infrastructure.Context
{
    public class eShopDbContext : DbContext
    {
        public eShopDbContext(DbContextOptions<eShopDbContext> options)
            : base(options)
            => Database.Migrate();

        public DbSet<Product> Products { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductFile> ProductFiles { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<Organization> Organizations { get; set; }
        public DbSet<OrganizationContact> OrganizationContacts { get; set; }
        public DbSet<OrganizationFile> OrganizationFiles { get; set; }
        public DbSet<OrganizationFounder> OrganizationFounders { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<UserPermission> UsersPermissions { get; set; }
        public DbSet<UserRole> UsersRoles { get; set; }
        public DbSet<UserRolePermission> UsersRolesPermissions { get; set; }

        public DbSet<Region> Regions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(assembly: Assembly.GetExecutingAssembly());

            modelBuilder.Entity<UserRole>()
                .HasMany(x => x.Permissions)
                .WithMany(x => x.Roles)
                .UsingEntity<UserRolePermission>();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var softDeleteEntries = ChangeTracker
                .Entries<ISoftDeletable>()
                .Where(x => x.State == EntityState.Deleted);

            foreach (var entry in softDeleteEntries)
            {
                entry.State = EntityState.Modified;
                entry.Property(nameof(ISoftDeletable.IsDeleted)).CurrentValue = true;
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
