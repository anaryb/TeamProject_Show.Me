using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject_ShowMe
{
    public class Movie : MediaCentre
    {
        List<Movie> Movies = new List<Movie>();
        public DateTime Duration;
        
        public Movie(int Id, string Name, DateTime Year, double Raiting, string Discroption, DateTime Duration) :
            base(Id, Name, Year, Raiting, Discroption)
        {
            this.Duration = Duration;
        }
        
        
        
        
    }
}
