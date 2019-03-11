using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReviewMVC.Models
{
    public class Film
    {
        public virtual int FilmID { get; set; }
        public virtual int ActorID { get; set; }
        public virtual int DirectorID { get; set; }
        public virtual int GenreID { get; set; }
        public virtual string FilmName { get; set; }
        public virtual DateTime ReleaseDate { get; set; }
        public virtual string Rating { get; set; }
        public virtual string Runtime { get; set; }
        public virtual string Studio { get; set; }

        public virtual Actor Actor { get; set;}
        public virtual Genre Genre { get; set; }
        public virtual Director Director { get; set; }

       

       
    }
}