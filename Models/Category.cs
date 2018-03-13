using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ReviewAppFinal.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [Display(Name = "Category")]
        public string Name { get; set; }

        //Navigation property
        public virtual ICollection<Review> Review
        { get; set; }
    }
}
