using System.ComponentModel.DataAnnotations;

namespace Dashboard.Data.Models
{
    public class Address
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Street { get; set; }

        [Required]
        [Display(Name = "Postal code")]
        [StringLength(10, MinimumLength = 4)]
        public string PostalCode { get; set; }

        [Required]
        [StringLength(10)]
        public string City { get; set; }

        [Required]
        [StringLength(50)]
        public string Country { get; set; }
    }
}
