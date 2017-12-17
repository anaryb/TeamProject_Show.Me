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
                new Show.Show{  Name = "Game of Thrones",Year = 2011, Rating = 4.7, Description = "One of the best shows on our TV", Genre = "Criminal", ImageShow = "Pictures/gameofthrones.jpg" },
                new Show.Show{  Name = "Peaky Blinders",Year = 2013, Rating = 4.9, Description = "Drama about Rich Shelby's family ", Genre = "Criminal Drama" , ImageShow = "Pictures/peakyblinders.jpg"},
                new Show.Show{  Name = "Big Bang Theory",Year = 2007, Rating = 4.2, Description = "A woman who moves into an apartment across the hall from two brilliant but socially awkward physicists shows them how little they know about life outside of the laboratory.", Genre = "Comedy", ImageShow = "Pictures/bigbangtheory.jpg" },
            };
            Episode.Episode[] episodes =
            {
            new Episode.Episode{  Name="01", Season=2, Show = shows[0]},
            new Episode.Episode{  Name="02", Season=1, Show = shows[1]},
            new Episode.Episode{ Name="03", Season=3, Show = shows[2]}
            };
            Movie.Movie[] movies =
            {
                new Movie.Movie {Name ="101 Dalmatians", Year = 1998, Description="Best story about dogs", Rating=4.5, Genre = "Cartoon", ImageMovie = "Pictures/101Dalmat.jpg"},
                new Movie.Movie {Name ="Cinderella", Year = 2000, Description="Based on the fairy tale Cinderella by Charles Perrault", Rating=3.5, Genre = "Cartoon", ImageMovie = "Pictures/cinderella.jpg"},
                new Movie.Movie {Name ="Kingsman", Year = 2015, Description="The Secret Service", Rating=4.8, Genre = "Comedy", ImageMovie = "Pictures/kingsman.jpg"},
            };
            context.Shows.AddOrUpdate(s => s.Name,shows);
            //context.Episodes.AddOrUpdate(e =>e.Show, episodes);
            context.Movies.AddOrUpdate(m => m.Name,movies);
        }
    }
}
