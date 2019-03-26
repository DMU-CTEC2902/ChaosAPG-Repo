namespace FilmReviewMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ActorComments",
                c => new
                    {
                        ActorCommentID = c.Int(nullable: false, identity: true),
                        ActorID = c.Int(nullable: false),
                        Comment = c.String(),
                        DateAdded = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ActorCommentID)
                .ForeignKey("dbo.Actors", t => t.ActorID, cascadeDelete: true)
                .Index(t => t.ActorID);
            
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        ActorID = c.Int(nullable: false, identity: true),
                        ActorName = c.String(),
                        DOB = c.DateTime(nullable: false),
                        Nationality = c.Int(nullable: false),
                        HighestRatedMovie = c.String(),
                    })
                .PrimaryKey(t => t.ActorID);
            
            CreateTable(
                "dbo.DirectorComments",
                c => new
                    {
                        DirectorCommentID = c.Int(nullable: false, identity: true),
                        DirectorID = c.Int(nullable: false),
                        Comment = c.String(),
                        DateAdded = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.DirectorCommentID)
                .ForeignKey("dbo.Directors", t => t.DirectorID, cascadeDelete: true)
                .Index(t => t.DirectorID);
            
            CreateTable(
                "dbo.Directors",
                c => new
                    {
                        DirectorID = c.Int(nullable: false, identity: true),
                        DirectorName = c.String(),
                        DOB = c.DateTime(nullable: false),
                        Nationality = c.String(),
                        HighestRatedMovie = c.String(),
                    })
                .PrimaryKey(t => t.DirectorID);
            
            CreateTable(
                "dbo.Films",
                c => new
                    {
                        FilmID = c.Int(nullable: false, identity: true),
                        ActorID = c.Int(nullable: false),
                        DirectorID = c.Int(nullable: false),
                        GenreID = c.Int(nullable: false),
                        FilmName = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        Rating = c.String(),
                        Runtime = c.String(),
                        Studio = c.String(),
                    })
                .PrimaryKey(t => t.FilmID)
                .ForeignKey("dbo.Actors", t => t.ActorID, cascadeDelete: true)
                .ForeignKey("dbo.Directors", t => t.DirectorID, cascadeDelete: true)
                .ForeignKey("dbo.Genres", t => t.GenreID, cascadeDelete: true)
                .Index(t => t.ActorID)
                .Index(t => t.DirectorID)
                .Index(t => t.GenreID);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreID = c.Int(nullable: false, identity: true),
                        GenreType = c.String(),
                    })
                .PrimaryKey(t => t.GenreID);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        NewsID = c.Int(nullable: false, identity: true),
                        NewsWriter = c.String(),
                        DatePublished = c.Int(nullable: false),
                        FilmID = c.Int(nullable: false),
                        ActorID = c.String(),
                        DirectorID = c.String(),
                        Actor_ActorID = c.Int(),
                        Director_DirectorID = c.Int(),
                    })
                .PrimaryKey(t => t.NewsID)
                .ForeignKey("dbo.Actors", t => t.Actor_ActorID)
                .ForeignKey("dbo.Directors", t => t.Director_DirectorID)
                .ForeignKey("dbo.Films", t => t.FilmID, cascadeDelete: true)
                .Index(t => t.FilmID)
                .Index(t => t.Actor_ActorID)
                .Index(t => t.Director_DirectorID);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewID = c.Int(nullable: false, identity: true),
                        FilmID = c.Int(nullable: false),
                        ReviewDate = c.DateTime(nullable: false),
                        ReviewDetails = c.String(),
                        ReviewRating = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReviewID)
                .ForeignKey("dbo.Films", t => t.FilmID, cascadeDelete: true)
                .Index(t => t.FilmID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "FilmID", "dbo.Films");
            DropForeignKey("dbo.News", "FilmID", "dbo.Films");
            DropForeignKey("dbo.News", "Director_DirectorID", "dbo.Directors");
            DropForeignKey("dbo.News", "Actor_ActorID", "dbo.Actors");
            DropForeignKey("dbo.Films", "GenreID", "dbo.Genres");
            DropForeignKey("dbo.Films", "DirectorID", "dbo.Directors");
            DropForeignKey("dbo.Films", "ActorID", "dbo.Actors");
            DropForeignKey("dbo.DirectorComments", "DirectorID", "dbo.Directors");
            DropForeignKey("dbo.ActorComments", "ActorID", "dbo.Actors");
            DropIndex("dbo.Reviews", new[] { "FilmID" });
            DropIndex("dbo.News", new[] { "Director_DirectorID" });
            DropIndex("dbo.News", new[] { "Actor_ActorID" });
            DropIndex("dbo.News", new[] { "FilmID" });
            DropIndex("dbo.Films", new[] { "GenreID" });
            DropIndex("dbo.Films", new[] { "DirectorID" });
            DropIndex("dbo.Films", new[] { "ActorID" });
            DropIndex("dbo.DirectorComments", new[] { "DirectorID" });
            DropIndex("dbo.ActorComments", new[] { "ActorID" });
            DropTable("dbo.Reviews");
            DropTable("dbo.News");
            DropTable("dbo.Genres");
            DropTable("dbo.Films");
            DropTable("dbo.Directors");
            DropTable("dbo.DirectorComments");
            DropTable("dbo.Actors");
            DropTable("dbo.ActorComments");
        }
    }
}
