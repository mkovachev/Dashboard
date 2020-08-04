using System.ComponentModel.DataAnnotations;
using static Dashboard.Server.Data.DataValidator.Item;

namespace Dashboard.Data.Models
{
    public class Item
    {
        public int Id { get; set; }

        [MaxLength(ItemsDescriptionMaxLength)]
        public string Description { get; set; }

        //[Required]
        public string ImageUrl { get; set; }

        [Required]
        public string UserId { get; set; }

        public User User { get; set; }
    }
}
