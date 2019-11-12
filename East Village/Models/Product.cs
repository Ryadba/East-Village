using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace East_Village.Models
{
    public class Product
    {
        public int Id { get; set; }
        [DisplayName("Product Name")]
        public string ProductTitle { get; set; }
        [DisplayName("Product Details")]
        public string ProductContent { get; set; }
        [DisplayName("Product Image")]
        public string ProductImage { get; set; }

        [DisplayName("Product Type")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        
    }
}