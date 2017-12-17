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
                new Show.Show{  Name = "Brain on fire",Year = 2017, Rating = 4.7, Description = "a", Genre = "Horror", ImageShow = "Pictures/101Dalmat.jpg" },
                new Show.Show{  Name = "HTAWM",Year = 2016, Rating = 4.9, Description = "b", Genre = "Romance" , ImageShow = "Pictures/101Dalmat.jpg"},
                new Show.Show{  Name = "love the world",Year = 1998, Rating = 4.2, Description = "c", Genre = "Comedy", ImageShow = "Pictures/101Dalmat.jpg" },
            };
            Episode.Episode[] episodes =
            {
            new Episode.Episode{  Name="01", Season=2, Show = shows[0]},
            new Episode.Episode{  Name="02", Season=1, Show = shows[1]},
            new Episode.Episode{ Name="03", Season=3, Show = shows[2]}
            };
            Movie.Movie[] movies =
            {
                new Movie.Movie {Name ="101 Dalmatinez", Year = 1998, Description="hello", Rating=4.5, Genre = "Cartoon", ImageMovie = "Pictures/101Dalmat.jpg"},
                new Movie.Movie {Name ="Cinderella", Year = 2000, Description="privi", Rating=3.5, Genre = "Cartoon", ImageMovie = "Pictures/cinderella.jpg"},
                new Movie.Movie {Name ="Kingsman", Year = 2015, Description="funny", Rating=4.8, Genre = "Comedy", ImageMovie = "Pictures/cinderella.jpg"},
            };
            context.Shows.AddOrUpdate(s => s.Name,shows);
            //context.Episodes.AddOrUpdate(e =>e.Show, episodes);
            context.Movies.AddOrUpdate(m => m.Name,movies);
        }
    }
}
