using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject_ShowMe.Show
{
    public interface IShowRepository
    {
        IEnumerable<Show> Shows { get; }

        void AddShow(Show show);

        void RemoveShow(Show show);

        void UpdateShow(Show show);

        void Load();
    }
}
