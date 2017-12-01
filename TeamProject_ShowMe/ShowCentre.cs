using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject_ShowMe
{
    public abstract class ShowCentre
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Year { get; set; }

        public string Discription{ get; set; }

        public double Raiting { get; set; }

        public ShowCentre(int Id, string Name, DateTime Year, double Raiting, string Discription)
        {
            this.Id = Id;
            this.Name = Name;
            this.Year = Year;
            this.Raiting = Raiting;
            this.Discription = Discription;

        }
    }
}
