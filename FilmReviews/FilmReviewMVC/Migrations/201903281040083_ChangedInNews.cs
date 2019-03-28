namespace FilmReviewMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    //public partial class ChangedInNews : DbMigration
    //{
    //    public override void Up()
    //    {
    //        DropForeignKey("dbo.News", "Actor_ActorID", "dbo.Actors");
    //        DropIndex("dbo.News", new[] { "Actor_ActorID" });
    //        DropColumn("dbo.News", "ActorID");
    //        RenameColumn(table: "dbo.News", name: "Actor_ActorID", newName: "ActorID");
    //        AlterColumn("dbo.News", "ActorID", c => c.Int(nullable: false));
    //        AlterColumn("dbo.News", "ActorID", c => c.Int(nullable: false));
    //        CreateIndex("dbo.News", "ActorID");
    //        AddForeignKey("dbo.News", "ActorID", "dbo.Actors", "ActorID", cascadeDelete: true);
    //    }
        
    //    public override void Down()
    //    {
    //        DropForeignKey("dbo.News", "ActorID", "dbo.Actors");
    //        DropIndex("dbo.News", new[] { "ActorID" });
    //        AlterColumn("dbo.News", "ActorID", c => c.Int());
    //        AlterColumn("dbo.News", "ActorID", c => c.String());
    //        RenameColumn(table: "dbo.News", name: "ActorID", newName: "Actor_ActorID");
    //        AddColumn("dbo.News", "ActorID", c => c.String());
    //        CreateIndex("dbo.News", "Actor_ActorID");
    //        AddForeignKey("dbo.News", "Actor_ActorID", "dbo.Actors", "ActorID");
    //    }
    //}
}
