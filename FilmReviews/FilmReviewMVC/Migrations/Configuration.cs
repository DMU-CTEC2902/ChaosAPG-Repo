namespace FilmReviewMVC.Migrations
{
    using FilmReviewMVC.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FilmReviewMVC.Models.FilmContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "FilmReviewMVC.Models.FilmContext";
        }

        protected override void Seed(FilmReviewMVC.Models.FilmContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //this is an object of genre
            Genre genre1 = new Genre();
            //object of genreID
            genre1.GenreID = 1;
            genre1.GenreType = "Comedy";
            context.Genres.AddOrUpdate(genre1);

            Genre genre2 = new Genre();
            genre2.GenreID = 2;
            genre2.GenreType = "Horror";
            context.Genres.AddOrUpdate(genre2);

            Genre genre3 = new Genre();
            genre3.GenreID = 3;
            genre3.GenreType = "Documentary";
            context.Genres.AddOrUpdate(genre3);

            Genre genre4 = new Genre();
            genre4.GenreID = 4;
            genre4.GenreType = "Sci-fi";
            context.Genres.AddOrUpdate(genre4);

            //Available actors 
            Actor actor1 = new Actor();
            actor1.ActorID = 1;
            actor1.ActorName = "Jhon";
            actor1.DOB = new DateTime(2012, 12, 12);
            context.Actors.AddOrUpdate(actor1);

            Actor actor2 = new Actor();
            actor2.ActorID = 2;
            actor2.ActorName = "Mark";
            actor2.DOB = new DateTime(2013, 12, 12);
            context.Actors.AddOrUpdate(actor2);

            Actor actor3 = new Actor();
            actor3.ActorID = 3;
            actor3.ActorName = "Josh";
            actor3.DOB = new DateTime(2014, 12, 12);
            context.Actors.AddOrUpdate(actor3);

            Actor actor4 = new Actor();
            actor4.ActorID = 4;
            actor4.ActorName = "Paul";
            actor4.DOB = new DateTime(2012, 12, 12);
            context.Actors.AddOrUpdate(actor4);

            //first director 

            Director director1 = new Director();
            //showing the director ID
            director1.DirectorID = 1;
            //showing the directors name
            director1.DirectorName = "Steven";
            //using the DateTime variable for the directors film date
            director1.DOB = new DateTime(2019, 12, 12);
            context.Directors.AddOrUpdate(director1);

            //second director

            Director director2 = new Director();
            //showing the director ID
            director2.DirectorID = 2;
            //showing the directors name
            director2.DirectorName = "Alex";
            //using the DateTime variable for the directors film date
            director2.DOB = new DateTime(2019, 12, 12);
            context.Directors.AddOrUpdate(director2);

            //first film 

            Film film1 = new Film();
            //Variable to store the Film ID and display it
            film1.FilmID = 1;
            //Variable to store the Genre ID and display it
            film1.GenreID = 3;
            //Variable to store the Actor ID and display it
            film1.ActorID = 1;
            //Variable to store the Director ID and display it
            film1.DirectorID = 1;
            //Variable to store Film Name
            film1.FilmName = "Madagascar";
            //Variable to store Release Date
            film1.ReleaseDate = new DateTime(2012, 12, 12);
            //Variable to store the Rating
            film1.Rating = "7";
            //Variable to store the RunTime
            film1.Runtime = "1 hour";
            //Variable to store the Studio 
            film1.Studio = "DreamWorks";
            ////Code responsible for adding the first film 
            context.Films.AddOrUpdate(film1);

            //Second Film 

            Film film2 = new Film();
            //Variable to store the Film ID and display it
            film2.FilmID = 2;
            //Variable to store the Genre ID and display it
            film2.GenreID = 2;
            //Variable to store the Actor ID and display it
            film2.ActorID = 4;
            //Variable to store the Director ID and display it
            film2.DirectorID = 1;
            //Variable to store Film Name
            film2.FilmName = "Avengers Assemble";
            //Variable to store Release Date
            film2.ReleaseDate = new DateTime(2014, 12, 12);
            //Variable to store the Rating
            film2.Rating = "5";
            //Variable to store the RunTime
            film2.Runtime = "2 hour";
            //Variable to store the Studio 
            film2.Studio = "Warner Brothers";
            ////Code responsible for adding the first film 
            context.Films.AddOrUpdate(film2);


            //Third Film

            Film film3 = new Film();
            //Variable to store the Film ID and display it
            film3.FilmID = 3;
            //Variable to store the Genre ID and display it
            film3.GenreID = 3;
            //Variable to store the Actor ID and display it
            film3.ActorID = 1;
            //Variable to store the Director ID and display it
            film3.DirectorID = 2;
            //Variable to store Film Name
            film3.FilmName = "Spiderman";
            //Variable to store Release Date
            film3.ReleaseDate = new DateTime(2015, 12, 12);
            //Variable to store the Rating
            film3.Rating = "5";
            //Variable to store the RunTime
            film3.Runtime = "3 hour";
            //Variable to store the Studio 
            film3.Studio = "Orange fox studios";
            ////Code responsible for adding the first film 
            context.Films.AddOrUpdate(film3);

            //Fourth Film


            Film film4 = new Film();
            //Variable to store the Film ID and display it
            film4.FilmID = 4;
            //Variable to store the Genre ID and display it
            film4.GenreID = 3;
            //Variable to store the Actor ID and display it
            film4.ActorID = 2;
            //Variable to store the Director ID and display it
            film4.DirectorID = 2;
            //Variable to store Film Name
            film4.FilmName = "Captain Marvel";
            //Variable to store Release Date
            film4.ReleaseDate = Convert.ToDateTime("08/03/2019");
            //Variable to store the Rating
            film4.Rating = "7";
            //Variable to store the RunTime
            film4.Runtime = "2 hours";
            //Variable to store the Studio 
            film4.Studio = "Marvel";
            //Code responsible for adding the first film 
            context.Films.AddOrUpdate(film4);

            //Fifth Film

            Film film5 = new Film();
            //Variable to store the Film ID and display it
            film5.FilmID = 5;
            //Variable to store the Genre ID and display it
            film5.GenreID = 3;
            //Variable to store the Actor ID and display it
            film5.ActorID = 1;
            //Variable to store the Director ID and display it
            film5.DirectorID = 2;
            //Variable to store Film Name
            film5.FilmName = "Black Panther";
            //Variable to store Release Date
            film5.ReleaseDate = Convert.ToDateTime("12/10/2012");
            //Variable to store the Rating
            film5.Rating = "7";
            //Variable to store the RunTime
            film5.Runtime = "2 hours";
            //Variable to store the Studio 
            film5.Studio = "Marvel";
            //Code responsible for adding the first film 
            context.Films.AddOrUpdate(film5);
            base.Seed(context);
        }
    }
}
