using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MVC_Assignment.CustomValidations;

namespace MVC_Assignment.Models
{
    public class Contact
    {
        [Required]
        [NumericOnlyValidation(ErrorMessage = "Id must be only Numeric")]
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}