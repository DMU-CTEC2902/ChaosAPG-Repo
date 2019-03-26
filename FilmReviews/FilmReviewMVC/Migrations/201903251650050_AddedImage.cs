namespace FilmReviewMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedImage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "FilmImage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Films", "FilmImage");
        }
    }
}
