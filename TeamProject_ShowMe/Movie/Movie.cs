using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject_ShowMe.Movie
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Year { get; set; }

        public double Rating { get; set; }

        public string Genre { get; set; }

        public string Description { get; set; }

        public string ImageMovie { get; set; }

        public override string ToString()
        {
            return Id.ToString() + Name;
        }
    }
}
