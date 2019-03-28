using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReviewMVC.Models
{
    public class ActorComment
    {
        //int variable to store the ActorCommentID
        public virtual int ActorCommentID { get; set; }
        //int variable to store the ActorID
        public virtual int ActorID { get; set; }
        //string variable to store the comment
        public virtual string Comment { get; set; }
        //date time variable to store the DateAdded
        public virtual DateTime DateAdded { get; set; }

        //class variable to store Actor
        public virtual Actor Actor { get; set; }

    }
}