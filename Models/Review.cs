using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReviewAppFinal.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        [Display(Name = "Release Date: ")]
        public DateTime RelaseDate { get; set; }
        [Display(Name = "Description: ")]
        public string Description { get; set; }
        [Display(Name = "Tech Crunch Review: ")]
        public int ReviewScore { get; set; }

        [ForeignKey("Category")]
        public int CateogryID { get; set; }
        public virtual Category Category { get; set; }
    }
}