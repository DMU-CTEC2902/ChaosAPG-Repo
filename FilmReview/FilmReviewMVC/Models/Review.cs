using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReviewMVC.Models
{
    public class Review
    {
        public virtual int ReviewID { get; set;}
        public virtual int FilmID { get; set; }
        public virtual DateTime ReviewDate { get; set; }
        public virtual string ReviewDetails { get; set; }
        public virtual int ReviewRating { get; set; }

        public virtual Film Film { get; set; }
   
    }

}