using Dashboard.Data.Contracts;
using Dashboard.Data.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Dashboard.Server.Data.Models
{
    public class User : IdentityUser, IAuditable, IDeletable
    {
        public IEnumerable<Product> Products { get; } = new HashSet<Product>();

        public Address PrimaryAddress { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
        public DateTime? DeletedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
