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

    }

}