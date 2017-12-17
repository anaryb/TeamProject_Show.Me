using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data;

namespace TeamProject_ShowMe.Show
{
    public class ShowRepository: IShowRepository
    {
        public MediaCenterContext _db;

        public IEnumerable<Show> Shows { get { return _db.Shows.Local; } }

        public ShowRepository(MediaCenterContext db)
        { _db = db; }

        public void AddShow(Show show)
        {
            _db.Shows.Add(show);
            _db.SaveChanges();
        }

        public void UpdateShow(Show show)
        {
            _db.Entry(show).State = System.Data.Entity.EntityState.Modified;
            _db.SaveChanges();
        }

        public void RemoveShow(Show show)
        {
            if (show!=null)
            {
                _db.Entry(show).State = System.Data.Entity.EntityState.Deleted;
                _db.SaveChanges();
            }
            
        }

        public void Load()
        {
            _db.Shows.Load();
        }
    }
}
