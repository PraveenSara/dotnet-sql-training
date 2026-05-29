using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace MVC_Assignment.CustomValidations
{
    public class NumericOnlyValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return false;
            }
            return Regex.IsMatch(value.ToString(), @"^[0-9]+$");
        }
    }
}