namespace FilmReviewMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedUserNameToFilm : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "UserName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Films", "UserName");
        }
    }
}
