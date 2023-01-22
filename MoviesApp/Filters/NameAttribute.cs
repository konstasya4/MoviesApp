using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using MoviesApp.Models;

namespace MoviesApp.Filters
{
    public class NameAttribute : ValidationAttribute
    {
        public NameAttribute(int count)
        {
            Count = count;
        }

        public int Count { get; }


        public string GetErrorMessage() =>
            $"The length of this value can't be less than {Count}.";

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is string)
            {
                var lenght = ((String)value).Length;
                if (lenght < Count)
                {
                    return new ValidationResult(GetErrorMessage());
                }

                return ValidationResult.Success;
            }

            return new ValidationResult("Enter name correctly");
        }
    }
}