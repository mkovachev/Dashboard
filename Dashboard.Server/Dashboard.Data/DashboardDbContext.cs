using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Data
{
    public class DashboardDbContext : IdentityDbContext
    {
        public DashboardDBContext() { }

        public DashboardDBContext(DbContextOptions options) : base(options)
        {

        }

    }

}