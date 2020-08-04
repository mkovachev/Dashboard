using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Dashboard.Data.Models
{
    public class User : IdentityUser
    {
        public IEnumerable<Item> Items { get; } = new HashSet<Item>();
    }
}
