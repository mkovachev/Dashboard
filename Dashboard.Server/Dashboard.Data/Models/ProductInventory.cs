using Dashboard.Data.Contracts;
using System;

namespace Dashboard.Data.Models
{
    public class ProductInventory : IAuditable, IDeletable
    {
        public int Id { get; set; }
        public int CurrentQuantity { get; set; }

        public int MinQuantity { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public DateTime? DeletedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
