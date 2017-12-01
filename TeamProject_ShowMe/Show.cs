using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject_ShowMe
{
    public class Show:ShowCentre
    {
        public int Season { get; set; }
        public int Episode { get; set; }
        public Show(int Id, string Name, DateTime Year, double Raiting, string Discription, int Season, int Episode) :
            base(Id, Name, Year, Raiting, Discription)
        {
            this.Season = Season;
            this.Episode = Episode;
        }


    }
}
