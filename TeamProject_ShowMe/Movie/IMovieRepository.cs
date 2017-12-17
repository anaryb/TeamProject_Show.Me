using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject_ShowMe.Movie
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> Movies { get; }

        void AddMovie(Movie movie);
        void RemoveMovie(Movie movie);
        void UpdateMovie(Movie movie, string name, int year, double rating, string genre, string description, string imageMovie);
        IEnumerable SearchMovie(string searchParam);
        void Load();
    }
}
