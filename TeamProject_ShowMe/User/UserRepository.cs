using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject_ShowMe.User
{
    public class UserRepository : IUserRepository

    {
        MediaCenterContext _db = new MediaCenterContext();
        public IEnumerable<User> Users { get { return _db.Users.Local; } }

        public UserRepository(MediaCenterContext db)
        {
            _db = db;
        }

        public void AddUser(User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
        }

        public void Load(User user)
        {
            _db.Users.Load();
        }



    }
}
