using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace East_Village.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [Display (Name = "Category Name")]
        public string CategoryName { get; set; }
        [Required]
        [Display (Name = "Category Description")]
        public string CategoryDescription { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
} 