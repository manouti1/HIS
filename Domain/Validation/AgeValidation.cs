using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Validation
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]

    public class AgeValidation : ValidationAttribute
    {
        public static ValidationResult IsAgeValid(DateTime birthDate)
        {
            // Save today's date.
            var today = DateTime.Today;
            // Calculate the age.
            var age = today.Year - birthDate.Year;
            // Go back to the year the person was born in case of a leap year
            if (birthDate.Date > today.AddYears(-age)) age--;

            if (birthDate.Year <= today.Year || birthDate.Year > 1950)
            {
                return ValidationResult.Success;

            }
            else
            {
                return new ValidationResult("Please enter guardian value.");
            }
        }
    }
}
