using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject_ShowMe.User
{
    public interface IUserRepository
    {
        IEnumerable<User> Users { get; }

        void AddUser(User user);
        void Load(User user);
        string CalculateHash(string p);

    }
}
