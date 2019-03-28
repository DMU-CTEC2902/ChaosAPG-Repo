namespace FilmReviewMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedDataPublishedToDateTime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.News", "DatePublished", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.News", "DatePublished", c => c.Int(nullable: false));
        }
    }
}
