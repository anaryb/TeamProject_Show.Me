using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace TeamProject_ShowMe.Episode
{
    public class EpisodeRepository: IEpisodeRepository
    {
        private MediaCenterContext _db;

        public IEnumerable<Episode> Episodes { get { return _db.Episodes.Local; } }

        public EpisodeRepository(MediaCenterContext db)
        {
            _db = db;
        }
        public void Load()
        {
            _db.Episodes.Load();
        }
    }
}
