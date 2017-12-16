namespace TeamProject_ShowMe.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TeamProject_ShowMe.MediaCenterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TeamProject_ShowMe.MediaCenterContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            Show.Show[] shows =
            {
                new Show.Show{  Name = "Brain on fire",Year = new DateTime(2017,12,12), Rating = 4.7, Description = "a" },
                new Show.Show{  Name = "HTAWM",Year = new DateTime(2016,11,12), Rating = 4.9, Description = "b" },
                new Show.Show{  Name = "love the world",Year = new DateTime(1999,09,09), Rating = 4.2, Description = "c" },
            };
            Episode.Episode[] episodes =
            {
            new Episode.Episode{  Name="01", Season=2, Show = shows[0]},
            new Episode.Episode{  Name="02", Season=1, Show = shows[1]},
            new Episode.Episode{ Name="03", Season=3, Show = shows[2]}
            };
            Movie.Movie[] movies =
            {
                new Movie.Movie {Name ="101 Dalmatinez", Year = new DateTime(1998,12,30), Description="hello", Rating=4.5},
                new Movie.Movie {Name ="Cinderella", Year = new DateTime(2000,10,15), Description="privi", Rating=3.5},
            };
            context.Shows.AddOrUpdate(shows);
            context.Episodes.AddOrUpdate(episodes);
            context.Movies.AddOrUpdate(movies);

        }
    }
}
