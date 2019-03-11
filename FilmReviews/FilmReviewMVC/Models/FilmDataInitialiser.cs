using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace FilmReviewMVC.Models
{
    public class FilmDataInitialiser : DropCreateDatabaseAlways<FilmContext>
    {
        protected override void Seed(FilmContext context)
        {

            Film film1 = new Film();
            film1.FilmID = 1;
            film1.FilmName = "Madagascar";
            film1.Rating = "10";
            context.Films.Add(film1);
       

            base.Seed(context);

        }

    }
}