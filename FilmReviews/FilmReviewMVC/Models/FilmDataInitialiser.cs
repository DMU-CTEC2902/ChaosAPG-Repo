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
            

            Genre genre1 = new Genre();
            genre1.GenreID = 1;
            genre1.GenreType = "Comedy";
            context.Genres.Add(genre1);

            Genre genre1 = new Genre();
            genre1.GenreID = 1;
            genre1.GenreType = "Horror";
            context.Genres.Add(genre1);

            Genre genre1 = new Genre();
            genre1.GenreID = 1;
            genre1.GenreType = "Documentary";
            context.Genres.Add(genre1);

            Genre genre1 = new Genre();
            genre1.GenreID = 1;
            genre1.GenreType = "Sci-fi";
            context.Genres.Add(genre1);


            Actor actor1 = new Actor();
            actor1.ActorID = 1;
            actor1.ActorName = "Jhon";
            actor1.DOB = new DateTime(2012, 12, 12);
            context.Actors.Add(actor1);

            Actor actor1 = new Actor();
            actor1.ActorID = 1;
            actor1.ActorName = "Mark";
            actor1.DOB = new DateTime(2013, 12, 12);
            context.Actors.Add(actor1);

            Actor actor1 = new Actor();
            actor1.ActorID = 1;
            actor1.ActorName = "Josh";
            actor1.DOB = new DateTime(2014, 12, 12);
            context.Actors.Add(actor1);

            Actor actor1 = new Actor();
            actor1.ActorID = 1;
            actor1.ActorName = "Paul";
            actor1.DOB = new DateTime(2012, 12, 12);
            context.Actors.Add(actor1);

            //first director 

            Director director1 = new Director();
            //showing the director ID
            director1.DirectorID = 1;
            //showing the directors name
            director1.DirectorName = "Steven";
             //using the DateTime variable for the directors film date
            director1.DOB = new DateTime(2019, 12, 12);
            context.Directors.Add(director1);

            //second director
            Director director1 = new Director();
            //showing the director ID
            director1.DirectorID = 1;
            //showing the directors name
            director1.DirectorName = "Alex";
            //using the DateTime variable for the directors film date
            director1.DOB = new DateTime(2019, 12, 12);
            context.Directors.Add(director1);

            Film film1 = new Film();
            //Variable to store the Film ID and display it
            film1.FilmID = 1;
            //Variable to store the Genre ID and display it
            film1.GenreID = 1;
            //Variable to store the Actor ID and display it
            film1.ActorID = 1;
            //Variable to store the Director ID and display it
            film1.DirectorID = 1;
            //Variable to store Film Name
            film1.FilmName = "Madagascar";
            //Variable to store Release Date
            film1.ReleaseDate = new DateTime(2012,12,12);
            //Variable to store the Rating
            film1.Rating = "7";
            //Variable to store the RunTime
            film1.Runtime = "1 hour";
            //Variable to store the Studio 
            film1.Studio = "DreamWorks";
            ////Code responsible for adding the first film 
            context.Films.Add(film1);

            Film film1 = new Film();
            //Variable to store the Film ID and display it
            film1.FilmID = 1;
            //Variable to store the Genre ID and display it
            film1.GenreID = 1;
            //Variable to store the Actor ID and display it
            film1.ActorID = 1;
            //Variable to store the Director ID and display it
            film1.DirectorID = 1;
            //Variable to store Film Name
            film1.FilmName = "Avengers Assemble";
            //Variable to store Release Date
            film1.ReleaseDate = new DateTime(2014, 12, 12);
            //Variable to store the Rating
            film1.Rating = "5";
            //Variable to store the RunTime
            film1.Runtime = "2 hour";
            //Variable to store the Studio 
            film1.Studio = "Warner Brothers";
            ////Code responsible for adding the first film 
            context.Films.Add(film1);

            Film film1 = new Film();
            //Variable to store the Film ID and display it
            film1.FilmID = 1;
            //Variable to store the Genre ID and display it
            film1.GenreID = 1;
            //Variable to store the Actor ID and display it
            film1.ActorID = 1;
            //Variable to store the Director ID and display it
            film1.DirectorID = 1;
            //Variable to store Film Name
            film1.FilmName = "Spiderman";
            //Variable to store Release Date
            film1.ReleaseDate = new DateTime(2015, 12, 12);
            //Variable to store the Rating
            film1.Rating = "5";
            //Variable to store the RunTime
            film1.Runtime = "3 hour";
            //Variable to store the Studio 
            film1.Studio = "Orange fox studios";
            ////Code responsible for adding the first film 
            context.Films.Add(film1);

            ////Second Film




            Film film2 = new Film();
            //Variable to store the Film ID and display it
            film2.FilmID = 2;
            //Variable to store Film Name
            film2.FilmName = "Captain Marvel";
            //Variable to store Release Date
            film2.ReleaseDate = Convert.ToDateTime("08/03/2019");
            //Variable to store the Rating
            film2.Rating = "7";
            //Variable to store the RunTime
            film2.Runtime = "2 hours";
            //Variable to store the Studio 
            film2.Studio = "Marvel";
            //Code responsible for adding the first film 
            context.Films.Add(film1);

            //Third Film
            Film film3 = new Film();
            //Variable to store the Film ID and display it
            film1.FilmID = 3;
            //Variable to store Film Name
            film1.FilmName = "Black Panther";
            //Variable to store Release Date
            film1.ReleaseDate = Convert.ToDateTime("12/10/2012");
            //Variable to store the Rating
            film1.Rating = "7";
            //Variable to store the RunTime
            film1.Runtime = "2 hours";
            //Variable to store the Studio 
            film1.Studio = "Marvel";
            //Code responsible for adding the first film 
            context.Films.Add(film1);
            base.Seed(context);

        }

    }
}