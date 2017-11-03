using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public string ReviewTitle { get; set; }
        public DateTime DatePublished { get; set; }
        public string ReviewText { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}