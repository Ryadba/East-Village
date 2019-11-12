using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace East_Village.Models
{
    public class ContactModel
    {
        [Required(ErrorMessage = "Please Enter Your Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Your Email Address")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "This Field Is Required")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "This Field Is Required")]
        public string Message { get; set; }
    }
}