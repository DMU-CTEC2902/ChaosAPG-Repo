using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReviewMVC.Models
{
    public class NewsModel
    {
        public virtual int NewsId { get; set; }
        public virtual string NewsWriter { get; set; }
        public virtual int DatePublished { get; set; }
        public virtual int FilmId { get; set; }
        public virtual string ActorId { get; set; }
        public virtual string DirectorId { get; set; }
    }
}