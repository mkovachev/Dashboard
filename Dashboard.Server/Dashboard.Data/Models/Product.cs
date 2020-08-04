using System.ComponentModel.DataAnnotations;

namespace Dashboard.Data.Models
{
    public class Product
    {
        public int Id { get; set; }

        [MaxLength(DataValidator.ProductDescriptionMaxLength)]
        public string Description { get; set; }

        //[Required]
        public string ImageUrl { get; set; }

        [Required]
        public string UserId { get; set; }

        public User User { get; set; }
    }
}
