using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReviewMVC.Models
{
    public class Studio
    {
        public virtual int StudioId { get; set; }
        public virtual string ActorName { get; set; }
        public virtual int DOB { get; set; }
    }
}