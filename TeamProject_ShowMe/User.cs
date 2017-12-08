using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject_ShowMe
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public User(int Id, string Name, string Password)
        {
            this.Name = Name;
            this.Id = Id;
            this.Password = Password;//
        }
    }
}
