using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReviewMVC.Models
{
    public class Genre
    {
        //intvariable to store the GenreID
        public virtual int GenreID { get; set; }
        //string variable to store the GenreType
        public virtual string GenreType { get; set; }
    }
}