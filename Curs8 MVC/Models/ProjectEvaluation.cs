using Curs8_MVC.CustomAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Curs8_MVC.Models
{
    [Bind(Exclude = "Country")]
    //[Bind(Include = "all the other properties")]

    public class ProjectEvaluation
    {

        [MaxWordsAttribute(3)]
        public string name { get; set; }

        [Required]
        [StringLength(1000)]
        [MinWordsAttribute(2)]
        public string city { get; set; }
        
        public string country { get; set; }

        [Range(1, 10)]
        [Required]
        public double rating { get; set; }

        public int id { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (rating < 2 && name.ToLower().StartsWith("john"))
                yield return new ValidationResult("Sorry !!!");
        }

        public IEnumerable<ValidationResult> Validare(ValidationContext validationContext)
        {
            if (rating > 8 && name.ToLower().StartsWith("razvan"))
                yield return new ValidationResult("A very good rating !!!");
        }
    }
}