using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamProject_ShowMe.Movie;
using TeamProject_ShowMe.Show;
using TeamProject_ShowMe.Episode;
using TeamProject_ShowMe.User;
//using TeamProject_ShowMe.User;

namespace TeamProject_ShowMe
{
    public class MediaCenterContext: DbContext
    {
        public DbSet<Movie.Movie> Movies { get; set; }
        public DbSet<Show.Show> Shows { get; set; }
        public DbSet<Episode.Episode> Episodes { get; set; }
        public DbSet<User.User> Users { get; set; }

        public IMovieRepository MovieRepository { get; private set; }
        public IShowRepository ShowRepository { get; private set; }
        public IEpisodeRepository EpisodeRepository { get; private set; }
        public IUserRepository  UserRepository { get; private set; }

        public MediaCenterContext() : base("MC_SQL")
        {
            MovieRepository = new MovieRepository(this);
            ShowRepository = new ShowRepository(this);
            EpisodeRepository = new EpisodeRepository(this);
            UserRepository = new UserRepository(this);

        }



    }
}
