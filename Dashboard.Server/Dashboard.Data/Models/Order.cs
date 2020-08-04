using Dashboard.Data.Contracts;
using System;
using System.Collections.Generic;

namespace Dashboard.Data.Models
{
    public class Order : IAuditable, IDeletable
    {
        public int Id { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

        public ICollection<ShippingDetail> ShippingDetails { get; set; } = new List<ShippingDetail>();

        public bool IsPaid { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public DateTime? DeletedOn { get; set; }

        public bool IsDeleted { get; set; }
    }
}
