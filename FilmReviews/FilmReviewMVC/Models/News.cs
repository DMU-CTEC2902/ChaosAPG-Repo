using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReviewMVC.Models
{
    public class News
    {
        //int variable to store the NewsID
        public virtual int NewsID { get; set; }
        //string variable to store the NewsWriter
        public virtual string NewsWriter { get; set; }
        //DateTime variable to store the DatePublished
        public virtual DateTime DatePublished { get; set; }
        //int variable to store the FilmID
        public virtual int FilmID { get; set; }
        //string variable to store the ActorID
        public virtual string ActorID { get; set; }
        //string variable to store the DirectorID
        public virtual string DirectorID { get; set; }
        //string variable to store the NewsDescription
        public virtual string NewsDescription { get; set; }

        //class variable to store the Actor
        public virtual Actor Actor { get; set; }
        //class variable to store the Film
        public virtual Film Film { get; set; }
        //class variable to store Director
        public virtual Director Director { get; set; }
    }
}