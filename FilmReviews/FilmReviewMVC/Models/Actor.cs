using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReviewMVC.Models
{
    public class Actor
    {
        public virtual int ActorID { get; set; }
        public virtual string ActorName { get; set; }
        public virtual DateTime DOB { get; set; }
        public virtual int Nationality { get; set; }
        public virtual string HighestRatedMovie { get; set; }
    }
}