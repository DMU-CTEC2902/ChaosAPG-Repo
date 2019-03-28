using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReviewMVC.Models
{
    public class Film
    {
        //int variable to store the FilmID
        public virtual int FilmID { get; set; }
        //int variable to store the ActorID
        public virtual int ActorID { get; set; }
        //int variable to store the DirectorID
        public virtual int DirectorID { get; set; }
        //int variable to store the GenreID
        public virtual int GenreID { get; set; }
        //string variable to store the FilmName
        public virtual string FilmName { get; set; }
        //date time variable to store ReleaseDate
        public virtual DateTime ReleaseDate { get; set; }
        // string variable to store Rating
        public virtual string Rating { get; set; }
        //string variable to store the RunTime
        public virtual string Runtime { get; set; }
        //string variable to store the Studio
        public virtual string Studio { get; set; }
        //string variable to store the FilmImage
        public virtual string FilmImage { get; set;}
        //class variable to store the Actor
        public virtual Actor Actor { get; set; }
        //class variable to store the Genre
        public virtual Genre Genre { get; set; }
        //class variable to store the Director
        public virtual Director Director { get; set; }
        //string variable to store UserName
        public virtual string UserName { get; set; }
    }
}