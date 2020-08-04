using System.ComponentModel.DataAnnotations;

namespace Dashboard.Data.Models
{
    public class Product
    {
        public int Id { get; set; }

        [MinLength(DataValidator.ProductNameMinLength)]
        [MaxLength(DataValidator.ProductNameMaxLength)]
        public string Name { get; set; }

        [MinLength(DataValidator.ProductDescriptionMinLength)]
        [MaxLength(DataValidator.ProductNameMaxLength)]
        public string Description { get; set; }

        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public bool IsTaxable { get; set; }
        public bool IsArchived { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }
    }
}
