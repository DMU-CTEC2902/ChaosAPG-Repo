using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReviewMVC.Models
{
    public class Review
    {
        //int variable to store ReviewID
        public virtual int ReviewID { get; set; }
        //int variable to store FilmID
        public virtual int FilmID { get; set; }
        //date time variable ReviewDate
        public virtual DateTime ReviewDate { get; set; }
        //string variable to store ReviewDetails
        public virtual string ReviewDetails { get; set; }
        //int variable to store ReviewRating
        public virtual int ReviewRating { get; set; }

        //class variable to store Film
        public virtual Film Film { get; set; }
    }
}