using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject_ShowMe.Episode
{
    public class Episode
    {
        public int Id { get; set; }

        public Show.Show Show { get; set; }

        public string Name { get; set; }
        
        public int Season { get; set; }

        //duration...
    }
}
