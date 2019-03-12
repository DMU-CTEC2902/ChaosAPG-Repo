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
            ////First Film 

            Genre genre1 = new Genre();
            genre1.GenreID = 1;
            genre1.GenreType = "Comedy";
            context.Genres.Add(genre1);

            Actor actor1 = new Actor();
            actor1.ActorID = 1;
            actor1.ActorName = "Jhon";
            context.Actors.Add(actor1);

            Film film1 = new Film();
            //Variable to store the Film ID and display it
            film1.FilmID = 1;
            film1.GenreID = 1;
            //Variable to store Film Name
            film1.FilmName = "Madagascar";
            //Variable to store Release Date
            film1.ReleaseDate = Convert.ToDateTime("12/10/2005");
            //Variable to store the Rating
            film1.Rating = "7";
            //Variable to store the RunTime
            film1.Runtime = "1 hour";
            //Variable to store the Studio 
            film1.Studio = "DreamWorks";
            ////Code responsible for adding the first film 
            context.Films.Add(film1);

            ////Second Film

            //Film film2 = new Film();
            ////Variable to store the Film ID and display it
            //film2.FilmID = 2;
            ////Variable to store Film Name
            //film2.FilmName = "Captain Marvel";
            ////Variable to store Release Date
            //film2.ReleaseDate = Convert.ToDateTime("08/03/2019");
            ////Variable to store the Rating
            //film2.Rating = "7";
            ////Variable to store the RunTime
            //film2.Runtime = "2 hours";
            ////Variable to store the Studio 
            //film2.Studio = "Marvel";
            ////Code responsible for adding the first film 
            //context.Films.Add(film1);

            ////Third Film
            //Film film3 = new Film();
            ////Variable to store the Film ID and display it
            //film1.FilmID = 3;
            ////Variable to store Film Name
            //film1.FilmName = "Black Panther";
            ////Variable to store Release Date
            //film1.ReleaseDate = Convert.ToDateTime("12/10/2012");
            ////Variable to store the Rating
            //film1.Rating = "7";
            ////Variable to store the RunTime
            //film1.Runtime = "2 hours";
            ////Variable to store the Studio 
            //film1.Studio = "Marvel";
            ////Code responsible for adding the first film 
            //context.Films.Add(film1);
            base.Seed(context);

        }

    }
}