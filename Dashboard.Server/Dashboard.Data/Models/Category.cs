﻿using Dashboard.Data.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dashboard.Data.Models
{
    public class Category : IAuditable, IDeletable
    {
        public int Id { get; set; }

        [Required]
        [MinLength(DataValidator.CategoryNameMinLength)]
        [MaxLength(DataValidator.CategoryNameMaxLength)]
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; } = new List<Product>();

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public DateTime? DeletedOn { get; set; }

        public bool IsDeleted { get; set; }
    }
}
