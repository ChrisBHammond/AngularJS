namespace API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateVideoGameClassAddDeveloperprop : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VideoGames", "Developer", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.VideoGames", "Developer");
        }
    }
}
