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

        public void UpdateMovie(Movie movie, string name, int year,double rating,string genre, string description, string imageMovie)
        {
            using (TeamProject_ShowMe.MediaCenterContext db = new TeamProject_ShowMe.MediaCenterContext())
            {
                //db.Entry(movie).State = System.Data.Entity.EntityState.Modified;
                db.Movies.Find(movie.Id).Name = name;
                db.Movies.Find(movie.Id).Year = year;
                db.Movies.Find(movie.Id).Rating = rating;
                db.Movies.Find(movie.Id).Genre = genre;
                db.Movies.Find(movie.Id).Description = description;
                db.Movies.Find(movie.Id).ImageMovie = imageMovie;
                db.SaveChanges();

            }
                
        }

        public void RemoveMovie(Movie movie)
        {
            using (TeamProject_ShowMe.MediaCenterContext db = new TeamProject_ShowMe.MediaCenterContext())
            {
                if(movie !=null)
                {
                    db.Entry(movie).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                    
                }
            }
                
        }

        public void Load()
        {
            _db.Movies.Load();
        }
    }
}
