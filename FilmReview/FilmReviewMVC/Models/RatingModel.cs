using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReviewMVC.Models
{
    public class Rating
    {
        public virtual int RatingId { get; set; }
        public virtual string Rating { get; set; }
      
    }
}