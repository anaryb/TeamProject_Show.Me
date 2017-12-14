using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject_ShowMe.Episode
{
    public interface IEpisodeRepository
    {
        IEnumerable<Episode> Episodes { get; }

        void Load();
    }
}
