using Dashboard.Server.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Server.Data
{
    public class DashboardDbContext : IdentityDbContext<User>
    {
        public DashboardDbContext() { }

        public DashboardDbContext(DbContextOptions<DashboardDbContext> options) : base(options)
        {

        }

        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Item>().ToTable("Items");

            builder
                .Entity<User>()
                .HasMany(u => u.Items)
                .WithOne();

            builder
                .Entity<Item>()
                .HasOne(i => i.User)
                .WithMany(u => u.Items)
                .HasForeignKey(i => i.UserId)
                .IsRequired();
            //.OnDelete(DeleteBehavior.Restrict);

            //builder.Entity<Item>()
            //    .Property(i => i.UserId)
            //    .IsRequired();

            base.OnModelCreating(builder);
        }
    }

}