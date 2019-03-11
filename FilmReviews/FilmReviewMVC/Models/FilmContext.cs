using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using FilmReviewMVC.Models;
namespace FilmReviewMVC.Models
{
    public class FilmContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public FilmContext() : base("name=FilmContext")
        {
        }

        public DbSet<FilmReviewMVC.Models.Film> Films { get; set; }

        public DbSet<FilmReviewMVC.Models.Actor> Actors { get; set; }

        public DbSet<FilmReviewMVC.Models.Director> Directors { get; set; }

        public DbSet<FilmReviewMVC.Models.Genre> Genres { get; set; }

        public DbSet<FilmReviewMVC.Models.DirectorComment> DirectorComments { get; set; }

        public DbSet<FilmReviewMVC.Models.ActorComment> ActorComments { get; set; }

        public DbSet<FilmReviewMVC.Models.News> News { get; set; }

        public DbSet<FilmReviewMVC.Models.Review> Reviews { get; set; }
    }
}
