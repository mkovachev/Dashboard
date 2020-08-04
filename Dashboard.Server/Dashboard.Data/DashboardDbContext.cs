using Dashboard.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Data
{
    public class DashboardDbContext : IdentityDbContext<User>
    {
        public DashboardDbContext() { }

        public DashboardDbContext(DbContextOptions<DashboardDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductInventory> ProductInventories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ShippingDetail> ShippingDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>().ToTable("Products");
            builder.Entity<ProductInventory>().ToTable("ProductInventories");
            builder.Entity<Category>().ToTable("Categories");
            builder.Entity<Order>().ToTable("Orders");
            builder.Entity<OrderDetail>().ToTable("OrderDetails");
            builder.Entity<ShippingDetail>().ToTable("ShippingDetails");
            builder.Entity<Image>().ToTable("Images");

            //builder.Entity<Product>().ToTable("Products");

            //builder
            //    .Entity<User>()
            //    .HasMany(u => u.Products)
            //    .WithOne();

            //builder
            //    .Entity<Product>()
            //    .HasOne(i => i.User)
            //    .WithMany(u => u.Products)
            //    .HasForeignKey(i => i.UserId)
            //    .IsRequired();
            //.OnDelete(DeleteBehavior.Restrict);

            //builder.Entity<Product>()
            //    .Property(i => i.UserId)
            //    .IsRequired();

            base.OnModelCreating(builder);
        }
    }

}