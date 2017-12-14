using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TeamProject_ShowMe.Movie
{
    class MovieRepository:IMovieRepository
    {
        public MediaCenterContext _db;

        IEnumerable<Movie> IMovieRepository.Movies { get { return _db.Movies.Local; } }

        public MovieRepository(MediaCenterContext db)
        { _db = db; }

        public void AddMovie(Movie movie)
        {
            _db.Movies.Add(movie);
            _db.SaveChanges();
        }

        public void UpdateMovie(Movie movie)
        {
            _db.Entry(movie).State = System.Data.Entity.EntityState.Modified;
            _db.SaveChanges();
        }

        public void RemoveMovie(Movie movie)
        {
            _db.Movies.Remove(movie);
            _db.SaveChanges();
        }

        public void Load()
        {
            _db.Movies.Load();
        }
    }
}
