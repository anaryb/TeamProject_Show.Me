using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamProject_ShowMe.Movie;
using TeamProject_ShowMe.Show;
using TeamProject_ShowMe.Episode;

namespace TeamProject_ShowMe
{
    public class MediaCenterContext: DbContext
    {
        public DbSet<Movie.Movie> Movies { get; set; }
        public DbSet<Show.Show> Shows { get; set; }
        public DbSet<Episode.Episode> Episodes { get; set; }

        public IMovieRepository MovieRepository { get; private set; }
        public IShowRepository ShowRepository { get; private set; }
        public IEpisodeRepository EpisodeRepository { get; private set; }

        public MediaCenterContext() : base("localsql")
        {
            MovieRepository = new MovieRepository(this);
            ShowRepository = new ShowRepository(this);
            EpisodeRepository = new EpisodeRepository(this);

        }
    }
}
