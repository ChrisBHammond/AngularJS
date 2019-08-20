namespace API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateVideoGameClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VideoGames", "Platform", c => c.String());
            AddColumn("dbo.VideoGames", "ESRBRating", c => c.String());
            AddColumn("dbo.VideoGames", "ReleaseDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.VideoGames", "ReleaseDate");
            DropColumn("dbo.VideoGames", "ESRBRating");
            DropColumn("dbo.VideoGames", "Platform");
        }
    }
}
