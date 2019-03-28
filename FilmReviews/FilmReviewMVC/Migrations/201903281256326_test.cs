namespace FilmReviewMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    //public partial class test : DbMigration
    //{
    //    //public override void Up()
    //    //{
    //    //    DropForeignKey("dbo.News", "Actor_ActorID", "dbo.Actors");
    //    //    DropForeignKey("dbo.News", "Director_DirectorID", "dbo.Directors");
    //    //    DropIndex("dbo.News", new[] { "Actor_ActorID" });
    //    //    DropIndex("dbo.News", new[] { "Director_DirectorID" });
    //    //    DropColumn("dbo.News", "ActorID");
    //    //    DropColumn("dbo.News", "DirectorID");
    //    //    RenameColumn(table: "dbo.News", name: "Actor_ActorID", newName: "ActorID");
    //    //    RenameColumn(table: "dbo.News", name: "Director_DirectorID", newName: "DirectorID");
    //    //    AlterColumn("dbo.News", "ActorID", c => c.Int(nullable: false));
    //    //    AlterColumn("dbo.News", "DirectorID", c => c.Int(nullable: false));
    //    //    AlterColumn("dbo.News", "ActorID", c => c.Int(nullable: false));
    //    //    AlterColumn("dbo.News", "DirectorID", c => c.Int(nullable: false));
    //    //    CreateIndex("dbo.News", "ActorID");
    //    //    CreateIndex("dbo.News", "DirectorID");
    //    //    AddForeignKey("dbo.News", "ActorID", "dbo.Actors", "ActorID", cascadeDelete: true);
    //    //    AddForeignKey("dbo.News", "DirectorID", "dbo.Directors", "DirectorID", cascadeDelete: true);
    //    //}
        
    //    //public override void Down()
    //    //{
    //    //    DropForeignKey("dbo.News", "DirectorID", "dbo.Directors");
    //    //    DropForeignKey("dbo.News", "ActorID", "dbo.Actors");
    //    //    DropIndex("dbo.News", new[] { "DirectorID" });
    //    //    DropIndex("dbo.News", new[] { "ActorID" });
    //    //    AlterColumn("dbo.News", "DirectorID", c => c.Int());
    //    //    AlterColumn("dbo.News", "ActorID", c => c.Int());
    //    //    AlterColumn("dbo.News", "DirectorID", c => c.String());
    //    //    AlterColumn("dbo.News", "ActorID", c => c.String());
    //    //    RenameColumn(table: "dbo.News", name: "DirectorID", newName: "Director_DirectorID");
    //    //    RenameColumn(table: "dbo.News", name: "ActorID", newName: "Actor_ActorID");
    //    //    AddColumn("dbo.News", "DirectorID", c => c.String());
    //    //    AddColumn("dbo.News", "ActorID", c => c.String());
    //    //    CreateIndex("dbo.News", "Director_DirectorID");
    //    //    CreateIndex("dbo.News", "Actor_ActorID");
    //    //    AddForeignKey("dbo.News", "Director_DirectorID", "dbo.Directors", "DirectorID");
    //    //    AddForeignKey("dbo.News", "Actor_ActorID", "dbo.Actors", "ActorID");
    //    //}
    //}
}
