using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Data
{
    public class DashboardDbContext : IdentityDbContext
    {
        public DashboardDbContext() { }

        public DashboardDbContext(DbContextOptions options) : base(options)
        {

        }

    }

}