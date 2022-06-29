using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;

namespace Paladin.Infrastructure
{
    public class BirthdateValidator : ValidationAttribute
    {
        public BirthdateValidator()
        {
            ErrorMessage = "Please enter a valid birth date.  You must be 18 or older to apply.";
        }

        public override bool IsValid(object value)
        {
            DateTime enteredDate;
            if (DateTime.TryParse(value.ToString(), out enteredDate))
            {
                if (enteredDate > DateTime.Now.AddYears(-18))
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            else
            {
                return false;
            }
        }
    }
}