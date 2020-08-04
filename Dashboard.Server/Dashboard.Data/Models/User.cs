using Dashboard.Data.Contracts;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Dashboard.Server.Data.Models
{
    public class User : IdentityUser, IAuditable, IDeletable
    {
        public IEnumerable<Item> Items { get; } = new HashSet<Item>();

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
        public DateTime? DeletedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
