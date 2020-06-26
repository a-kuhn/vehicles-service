using System;
using System.ComponentModel.DataAnnotations;

namespace Mitchell_Vehicles.Validations
{
    public class YearAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            // if (year < 1950 || year > 2050): throw ValidationResult
            if ((int)value > 2050)
            {
                return new ValidationResult("must be between 1950 and 2050.");
            }
            else if ((int)value < 1950)
            {
                return new ValidationResult("must be between 1950 and 2050.");
            }

            else { return ValidationResult.Success; }

        }

    }
}