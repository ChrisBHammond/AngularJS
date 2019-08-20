namespace API.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<APIContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(APIContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //


            context.VideoGames.AddOrUpdate(

                new Models.VideoGame {
                    Name = "Ashes of the Singularity: Escalation",
                    Platform = "PC",
                    ReleaseDate = new DateTime(2016, 11, 10),
                    ESRBRating = "Everyone 10+",
                    Developer = "Stardock"
                },

                new Models.VideoGame
                {
                    Name = "Counter-Strike: Global Offensive",
                    Platform = "PC",
                    ReleaseDate = new DateTime(2012, 08, 21),
                    ESRBRating = "Everyone 10+",
                    Developer = "Valve"
                    
                },

                new Models.VideoGame
                {
                    Name = "Starcraft 2",
                    Platform = "PC",
                    ReleaseDate = new DateTime(2010, 07, 27),
                    ESRBRating = "Everyone 10+",
                    Developer = "Blizzard Entertainment"
                }

                );




        }
    }
}
