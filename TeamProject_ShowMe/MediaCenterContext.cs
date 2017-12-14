using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject_ShowMe
{
    class MediaCenterContext: DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Show> Shows { get; set; }

        public MediaCenterContext() : base("localsql") { }
    }
}
