namespace FilmReviewMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NationalityDataChange : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Actors", "Nationality", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Actors", "Nationality", c => c.Int(nullable: false));
        }
    }
}
