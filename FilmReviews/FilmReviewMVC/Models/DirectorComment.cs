using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReviewMVC.Models
{
    public class DirectorComment
    {
        public virtual int DirectorCommentID { get; set; }
        public virtual int DirectorID { get; set; }
        public virtual string Comment { get; set; }
        public virtual DateTime DateAdded { get; set; }

        public virtual Director Director { get; set; }
    }
}