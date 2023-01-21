using System;
using System.ComponentModel.DataAnnotations;
using MoviesApp.Models;

namespace MoviesApp.Filters
{
    public class OldActorAttribute : ValidationAttribute
    {
        public OldActorAttribute(int yearMax, int yearMin)
        {
            YearMin = yearMin;
            YearMax = yearMax;
        }

        public int YearMin { get; }
        public int YearMax { get; }
        

        public string GetErrorMessage() =>
            $"The actor must be at least {YearMin} years old and not older than {YearMax}.";

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var yearOfBirth = ((DateTime) value).Year;

            if (yearOfBirth >YearMin || yearOfBirth<YearMax)
            {
                return new ValidationResult(GetErrorMessage());
            }

            return ValidationResult.Success;
        }
    }
}
