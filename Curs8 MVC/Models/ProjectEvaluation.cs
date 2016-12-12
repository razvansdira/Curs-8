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
        public string name { get; set; }

        [Required]
        [MaxLength(1000)]
        public string city { get; set; }

        public string country { get; set; }

        [Range(1, 10)]
        [Required]
        public double rating { get; set; }

        public int id { get; set; }
    }
}