using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;

namespace TeamProject_ShowMe.Movie
{
    class MovieRepository:IMovieRepository
    {
        public MediaCenterContext _db;

        public IEnumerable<Movie> Movies { get { return _db.Movies.Local; } }

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
                if(movie !=null)
                {
                    _db.Entry(movie).State = System.Data.Entity.EntityState.Deleted;
                    _db.SaveChanges();
                    
                }
        }

        public void Load()
        {
            _db.Movies.Load();
        }


        string searchI;
        public IEnumerable SearchMovie(string searchParam)
        {
            searchI = searchParam;
            using (TeamProject_ShowMe.MediaCenterContext db = new TeamProject_ShowMe.MediaCenterContext())
            {
                var searchEl = db.Movies
                    .Where(el => el.Name.Contains(searchI)).ToList();
                return searchEl;
            }
        }

       


    }
}
