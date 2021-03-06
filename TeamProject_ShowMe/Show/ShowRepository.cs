﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data;
using System.Collections;

namespace TeamProject_ShowMe.Show
{
    public class ShowRepository: IShowRepository
    {
        public MediaCenterContext _db;

        public IEnumerable<Show> Shows { get { return _db.Shows.Local; } }

        public ShowRepository(MediaCenterContext db)
        {
            _db = db;
        }

        public void AddShow(Show show)
        {
            _db.Shows.Add(show);
            _db.SaveChanges();
        }

        public void UpdateShow(Show show)
        {
            if (show != null)
            {
                _db.Entry(show).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
            }
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

        string searchS;
        public IEnumerable SearchShow(string searchParam)
        {
            searchS = searchParam;
            using (TeamProject_ShowMe.MediaCenterContext db = new TeamProject_ShowMe.MediaCenterContext())
            {
                var searchEl = db.Shows
                    .Where(el => el.Name.Contains(searchS)).ToList();
                return searchEl;
            }
        }
    }
}
