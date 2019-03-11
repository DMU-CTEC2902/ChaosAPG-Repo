using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReviewMVC.Models
{
    public class DirectorModel
    {
        public virtual int DirectorID { get; set; }
        public virtual string DirectorName { get; set; }
        public virtual DateTime DOB { get; set; }
        public virtual string Nationality { get; set; }
        public virtual string HighestRatedMovie { get; set; }
    }
}