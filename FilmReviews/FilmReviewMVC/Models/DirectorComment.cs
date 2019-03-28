using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReviewMVC.Models
{
    public class DirectorComment
    {
        //int variable to store the DirectorCommentID
        public virtual int DirectorCommentID { get; set; }
        //int variable to store the DirectorID
        public virtual int DirectorID { get; set; }
        //string variable to store the Comment
        public virtual string Comment { get; set; }
        //date time variable to store the DateAdded
        public virtual DateTime DateAdded { get; set; }

        //class varaible to store Director
        public virtual Director Director { get; set; }
    }
}