using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReviewMVC.Models
{
    public class Film
    {
        public virtual int FilmId { get; set; }
        public virtual int ActorId { get; set; }
        public virtual int DirtectorId { get; set; }
        public virtual int GenreId { get; set; }
        public virtual string FilmName { get; set; }
        public virtual DateTime ReleaseDate { get; set; }
        public virtual string Rating { get; set; }
        public virtual string Runtime { get; set; }
        public virtual int ReviewId { get; set; }
        public virtual string Studio { get; set; }
        public virtual Actor ActorModel { get; set; }
        

    }
}