using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Curs8_MVC.CustomAttributes
{
    public class MinWordsAttribute : ValidationAttribute
    {
        private readonly int _minWords;
        public MinWordsAttribute(int minWords):base("{0} has to few words.")
        {
            _minWords = minWords;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value != null)
            {
                var valueAsString = value.ToString();
                if(valueAsString.Split(' ').Length < _minWords)
                {
                    var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(errorMessage);
                }
            }
            return ValidationResult.Success;
        }
    }
}