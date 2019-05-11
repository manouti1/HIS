using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Validation
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class GaudrianValidation : ValidationAttribute
    {

        public static ValidationResult IsGuardianValid(int givenAge)
        {
            if (givenAge > 15)
                return ValidationResult.Success;
            else
                return new ValidationResult("Please enter guardian value.");
        }
    }
}
