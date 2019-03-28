namespace FilmReviewMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNewsDescriptionToNews : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.News", "NewsDescription", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.News", "NewsDescription");
        }
    }
}
