using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReviewMVC.Models
{
    public class Actor
    {
        //int variable to store the ActorID
        public virtual int ActorID { get; set; }
        //string variable to store the ActorName
        public virtual string ActorName { get; set; }
        //DateTime variable to store the DOB
        public virtual DateTime DOB { get; set; }
        //string variable to store the Nationality
        public virtual string Nationality { get; set; }
        //string variable to store the HighestRatedMovie
        public virtual string HighestRatedMovie { get; set; }
    }
}