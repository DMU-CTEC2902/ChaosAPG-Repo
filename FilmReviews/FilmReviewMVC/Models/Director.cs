using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReviewMVC.Models
{
    public class Director
    {
        //int variable to store the DirectorID
        public virtual int DirectorID { get; set; }
        //string variable to store the DirectorName
        public virtual string DirectorName { get; set; }
        //date time variable to store the DOB
        public virtual DateTime DOB { get; set; }
        //string variable to store the Nationality
        public virtual string Nationality { get; set; }
        //string variable to store the HighestRatedMovie
        public virtual string HighestRatedMovie { get; set; }
    }
}