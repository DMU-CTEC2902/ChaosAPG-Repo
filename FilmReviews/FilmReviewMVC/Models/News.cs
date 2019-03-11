using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReviewMVC.Models
{
    public class News
    {
        public virtual int NewsID { get; set; }
        public virtual string NewsWriter { get; set; }
        public virtual int DatePublished { get; set; }
        public virtual int FilmID { get; set; }
        public virtual string ActorID { get; set; }
        public virtual string DirectorID { get; set; }


        public virtual Actor Actor { get; set; }
        public virtual Film Film { get; set; }
        public virtual Director Director { get; set; }
    }
}